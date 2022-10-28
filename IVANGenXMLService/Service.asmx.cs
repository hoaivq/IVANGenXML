using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace IVANGenXMLService
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {
        private ValidHoSos ValidHS
        {
            get { return File.ReadAllText(MyApp.Common.PathCombine(MyApp.Setting.AppPath, "ValidHoSos.xml")).ToObject<ValidHoSos>(); }
        }

        [WebMethod]
        public MsgResult GenXML_HoSo(Hoso objHoSo)
        {
            try
            {
                string MaThuTuc = objHoSo.NoiDung.ThongTinHoSo.MaThuTuc;
                List<FileToKhai> lstToKhai = objHoSo.NoiDung.ThongTinHoSo.ToKhais.FileToKhai;

                ValidToKhaiTrongHoso(MaThuTuc, lstToKhai);

                string MsgXML = objHoSo.ToXML<Hoso>();
                return new MsgResult(true, "", MsgXML);
            }
            catch (Exception ex)
            {
                // Đây, nếu throw exception ở hàm ValidToKhaiTrongHoso thì nó sẽ bay vào đây
                return new MsgResult("GenXML_HoSo", ex);
            }
        }


        [WebMethod]
        public MsgResult GenXML_D01(D01TS objToKhai)
        {
            try
            {
                string MsgXML = objToKhai.ToXML<D01TS>();
                return new MsgResult(true, "", MsgXML);
            }
            catch (Exception ex)
            {
                return new MsgResult("GenXML_D01", ex);
            }
        }


        private void ValidToKhaiTrongHoso(string MaThuTuc, List<FileToKhai> lstToKhai)
        {
            ValidHoSo validHoSo = ValidHS.ListValidHoSo.FirstOrDefault(c => c.MaThuTuc == MaThuTuc);
            if (validHoSo == null) // = null tức là ko tìm thấy
            {
                throw new Exception("Không tồn tại (hoặc chưa cấu hình valid) mã thủ tục " + MaThuTuc); // Sử dụng throw exception thì nó sẽ bay vào chỗ có try catch gần nhất
            }

            // Kiểm tra xem đã đủ tờ khai bắt buộc phải có chưa?
            string[] ListToKhaiPhaiCoArr = validHoSo.ListToKhaiPhaiCo.Split(','); // Cấu hình đang là <ListToKhaiPhaiCo>D05-TS,TK1-TS</ListToKhaiPhaiCo> cách nhau bởi dấu phẩy (,) nên phải dùng hàm split để biến nó thành 1 mảng array so sánh cho dễ

            // Quét các mã tờ khai có trong mảng Tờ khai phải có
            foreach (string MaToKhai in ListToKhaiPhaiCoArr)
            {
                // Nếu trong List tờ khai lstToKhai doanh nghiệp gửi lên không có MaToKhai bắt buộc phải có => return trả về lỗi luôn
                if (lstToKhai.Any(c => c.MaToKhai == MaToKhai) == false)
                {
                    throw new Exception("Thủ tục " + MaThuTuc + " thiếu tờ khai " + MaToKhai);
                }
            }

            // Kiểm tra xem có tờ khai nào không thuộc danh sách có thể có ko. Ví dụ tờ 602 thì ko thể gửi TK3 lên được
            string[] ListToKhaiCoTheCoArr = validHoSo.ListToKhaiCoTheCo.Split(',');

            // Quét trong list danh sách tờ khai doanh nghiệp gửi lên
            foreach (FileToKhai fileToKhai in lstToKhai)
            {
                // Nếu tờ khai này KHÔNG nằm trong danh sách tờ khai Có thể có => return lỗi luôn
                if (ListToKhaiCoTheCoArr.Any(c => c == fileToKhai.MaToKhai) == false)
                {
                    throw new Exception("Thủ tục " + MaThuTuc + " không cho phép nộp tờ khai " + fileToKhai.MaToKhai);
                }
            }

            // Nếu không nhảy vào Exception nào tức là Hồ sơ hợp lệ
        }
    }
}

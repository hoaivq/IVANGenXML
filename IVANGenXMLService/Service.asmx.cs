using Common;
using System;
using System.Collections.Generic;
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

        [WebMethod]
        public MsgResult GenXML_HoSo(Hoso objHoSo)
        {
            try
            {
                string MaThuTuc = objHoSo.NoiDung.ThongTinHoSo.MaThuTuc;
                List<FileToKhai> lstToKhai = objHoSo.NoiDung.ThongTinHoSo.ToKhais.FileToKhai;

                // Đoạn này sẽ phải valid theo từng thủ tục
                if (MaThuTuc == EMaThuTuc.H602)
                {
                    
                }
                else if (MaThuTuc == EMaThuTuc.H602)
                {

                }
                // Ông else if nốt các mã thủ tục còn lại nhé
                else
                {
                    return new MsgResult(false, "Không tồn tại mã thủ tục " + MaThuTuc);
                }

                string MsgXML = objHoSo.ToXML<Hoso>();
                return new MsgResult(true, "", MsgXML);
            }
            catch (Exception ex)
            {
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

    }
}

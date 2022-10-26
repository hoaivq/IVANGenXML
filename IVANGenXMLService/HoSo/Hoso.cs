using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace IVANGenXMLService
{
    [XmlRoot(ElementName = "Hoso")]
    public class Hoso
    {
        [XmlElement(ElementName = "NoiDung")]
        public NoiDung NoiDung { get; set; }
    }

    [XmlRoot(ElementName = "NoiDung")]
    public class NoiDung
    {
        [XmlElement(ElementName = "ThongTinIVAN")]
        public ThongTinIVAN ThongTinIVAN
        {
            get
            {
                return new ThongTinIVAN()
                {
                    MaIVAN = "00040",
                    TenIVAN = "Công ty THái Sơn"
                };
            }
        }

        [XmlElement(ElementName = "ThongTinDonVi")]
        public ThongTinDonVi ThongTinDonVi { get; set; }
        [XmlElement(ElementName = "ThongTinHoSo")]
        public ThongTinHoSo ThongTinHoSo { get; set; }
    }


    [XmlRoot(ElementName = "ThongTinIVAN")]
    public class ThongTinIVAN
    {
        [XmlElement(ElementName = "MaIVAN")]
        public string MaIVAN { get; set; }
        [XmlElement(ElementName = "TenIVAN")]
        public string TenIVAN { get; set; }
    }

    [XmlRoot(ElementName = "ThongTinDonVi")]
    public class ThongTinDonVi
    {
        [XmlElement(ElementName = "TenDoiTuong")]
        public string TenDoiTuong { get; set; }
        [XmlElement(ElementName = "MaSoBHXH")]
        public string MaSoBHXH { get; set; }
        [XmlElement(ElementName = "LoaiDoiTuong")]
        public string LoaiDoiTuong { get; set; }
        [XmlElement(ElementName = "MaSoThue")]
        public string MaSoThue { get; set; }
        [XmlElement(ElementName = "NguoiKy")]
        public string NguoiKy { get; set; }
        [XmlElement(ElementName = "DienThoai")]
        public string DienThoai { get; set; }
        [XmlElement(ElementName = "CoQuanQuanLy")]
        public string CoQuanQuanLy { get; set; }
    }

    [XmlRoot(ElementName = "ThongTinHoSo")]
    public class ThongTinHoSo
    {
        [XmlElement(ElementName = "TenThuTuc")]
        public string TenThuTuc { get; set; }
        [XmlElement(ElementName = "MaThuTuc")]
        public string MaThuTuc { get; set; }
        [XmlElement(ElementName = "KyKeKhai")]
        public string KyKeKhai { get; set; }
        [XmlElement(ElementName = "NgayLap")]
        public string NgayLap { get; set; }
        [XmlElement(ElementName = "SoLuongFile")]
        public string SoLuongFile { get; set; }
        [XmlElement(ElementName = "QuyTrinhISO")]
        public string QuyTrinhISO { get; set; }
        [XmlElement(ElementName = "ToKhais")]
        public ToKhais ToKhais { get; set; }
    }

    [XmlRoot(ElementName = "ToKhais")]
    public class ToKhais
    {
        [XmlElement(ElementName = "FileToKhai")]
        public List<FileToKhai> FileToKhai { get; set; }
    }


    [XmlRoot(ElementName = "FileToKhai")]
    public class FileToKhai
    {
        [XmlElement(ElementName = "MaToKhai")]
        public string MaToKhai { get; set; }
        [XmlElement(ElementName = "MoTaToKhai")]
        public string MoTaToKhai { get; set; }
        [XmlElement(ElementName = "TenFile")]
        public string TenFile { get; set; }
        [XmlElement(ElementName = "LoaiFile")]
        public string LoaiFile { get; set; }
        [XmlElement(ElementName = "DoDaiFile")]
        public string DoDaiFile { get; set; }
        [XmlElement(ElementName = "NoiDungFile")]
        public string NoiDungFile { get; set; }
    }








}

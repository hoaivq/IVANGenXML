using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace IVANGenXMLService.TK1
{
    [XmlRoot(ElementName = "TK1-TS")]
    public class TK1TS
    {
        [XmlElement(ElementName = "NoiDung")]
        public NoiDung NoiDung { get; set; }
    }

    [XmlRoot(ElementName = "ThanhVien")]
    public class ThanhVien
    {
        [XmlElement(ElementName = "STT")]
        public string STT { get; set; }
        [XmlElement(ElementName = "HoTen")]
        public string HoTen { get; set; }
        [XmlElement(ElementName = "MasoBHXH")]
        public string MasoBHXH { get; set; }
        [XmlElement(ElementName = "NgaySinh")]
        public string NgaySinh { get; set; }
        [XmlElement(ElementName = "GioiTinh")]
        public string GioiTinh { get; set; }
        [XmlElement(ElementName = "Matinh_KS")]
        public string Matinh_KS { get; set; }
        [XmlElement(ElementName = "Mahuyen_KS")]
        public string Mahuyen_KS { get; set; }
        [XmlElement(ElementName = "Maxa_KS")]
        public string Maxa_KS { get; set; }
        [XmlElement(ElementName = "MoiQuanHe")]
        public string MoiQuanHe { get; set; }
        [XmlElement(ElementName = "CMND")]
        public string CMND { get; set; }
        [XmlElement(ElementName = "Ghichu")]
        public string Ghichu { get; set; }
        [XmlElement(ElementName = "CCNS")]
        public string CCNS { get; set; }
        [XmlElement(ElementName = "NguoiThamGia")]
        public string NguoiThamGia { get; set; }
        [XmlElement(ElementName = "DanToc")]
        public string DanToc { get; set; }
        [XmlElement(ElementName = "QuocTich")]
        public string QuocTich { get; set; }
        [XmlElement(ElementName = "DiachiDK_KS")]
        public string DiachiDK_KS { get; set; }
    }

    [XmlRoot(ElementName = "DSThanhVien")]
    public class DSThanhVien
    {
        [XmlElement(ElementName = "ThanhVien")]
        public List<ThanhVien> ThanhVien { get; set; }
    }

    [XmlRoot(ElementName = "PhuLuc")]
    public class PhuLuc
    {
        [XmlElement(ElementName = "Hoten_Chuho")]
        public string Hoten_Chuho { get; set; }
        [XmlElement(ElementName = "DienThoai")]
        public string DienThoai { get; set; }
        [XmlElement(ElementName = "SoGiayTo")]
        public string SoGiayTo { get; set; }
        [XmlElement(ElementName = "LoaiGiayTo")]
        public string LoaiGiayTo { get; set; }
        [XmlElement(ElementName = "MaTinh")]
        public string MaTinh { get; set; }
        [XmlElement(ElementName = "MaHuyen")]
        public string MaHuyen { get; set; }
        [XmlElement(ElementName = "MaXa")]
        public string MaXa { get; set; }
        [XmlElement(ElementName = "MaThon")]
        public string MaThon { get; set; }
        [XmlElement(ElementName = "Maso_HoGiadinh")]
        public string Maso_HoGiadinh { get; set; }
        [XmlElement(ElementName = "Diachi_HK")]
        public string Diachi_HK { get; set; }
        [XmlElement(ElementName = "DSThanhVien")]
        public DSThanhVien DSThanhVien { get; set; }
    }

    [XmlRoot(ElementName = "LaoDong")]
    public class LaoDong
    {
        [XmlElement(ElementName = "STT")]
        public string STT { get; set; }
        [XmlElement(ElementName = "HoTen")]
        public string HoTen { get; set; }
        [XmlElement(ElementName = "NgaySinh")]
        public string NgaySinh { get; set; }
        [XmlElement(ElementName = "GioiTinh")]
        public string GioiTinh { get; set; }
        [XmlElement(ElementName = "QuocTich")]
        public string QuocTich { get; set; }
        [XmlElement(ElementName = "DanToc")]
        public string DanToc { get; set; }
        [XmlElement(ElementName = "Matinh_KS")]
        public string Matinh_KS { get; set; }
        [XmlElement(ElementName = "Mahuyen_KS")]
        public string Mahuyen_KS { get; set; }
        [XmlElement(ElementName = "Maxa_KS")]
        public string Maxa_KS { get; set; }
        [XmlElement(ElementName = "Diachi_NN")]
        public string Diachi_NN { get; set; }
        [XmlElement(ElementName = "Matinh_NN")]
        public string Matinh_NN { get; set; }
        [XmlElement(ElementName = "Mahuyen_NN")]
        public string Mahuyen_NN { get; set; }
        [XmlElement(ElementName = "Maxa_NN")]
        public string Maxa_NN { get; set; }
        [XmlElement(ElementName = "Ten_ChaMe_Giamho")]
        public string Ten_ChaMe_Giamho { get; set; }
        [XmlElement(ElementName = "MasoBHXH")]
        public string MasoBHXH { get; set; }
        [XmlElement(ElementName = "Dienthoai_LH")]
        public string Dienthoai_LH { get; set; }
        [XmlElement(ElementName = "CMND")]
        public string CMND { get; set; }
        [XmlElement(ElementName = "Maho_Giadinh")]
        public string Maho_Giadinh { get; set; }
        [XmlElement(ElementName = "Mucdong")]
        public string Mucdong { get; set; }
        [XmlElement(ElementName = "Phuongthuc")]
        public string Phuongthuc { get; set; }
        [XmlElement(ElementName = "MaTinhBenhVien")]
        public string MaTinhBenhVien { get; set; }
        [XmlElement(ElementName = "MaBenhVien")]
        public string MaBenhVien { get; set; }
        [XmlElement(ElementName = "Noidung_Thaydoi")]
        public string Noidung_Thaydoi { get; set; }
        [XmlElement(ElementName = "HosoKemtheo")]
        public string HosoKemtheo { get; set; }
        [XmlElement(ElementName = "CCNS")]
        public string CCNS { get; set; }
        [XmlElement(ElementName = "ID")]
        public string ID { get; set; }
        [XmlElement(ElementName = "Diachi_KS")]
        public string Diachi_KS { get; set; }
        [XmlElement(ElementName = "Email_LH")]
        public string Email_LH { get; set; }
        [XmlElement(ElementName = "PhuLuc")]
        public PhuLuc PhuLuc { get; set; }
    }

    [XmlRoot(ElementName = "NoiDung")]
    public class NoiDung
    {
        [XmlElement(ElementName = "LaoDong")]
        public List<LaoDong> LaoDong { get; set; }
    }



}

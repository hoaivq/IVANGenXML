using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace IVANGenXMLService
{
	[XmlRoot(ElementName = "D03-TS")]
	public class D03TS
	{
		[XmlElement(ElementName = "ThongTinKhac")]
		public ThongTinKhac_D03TS ThongTinKhac { get; set; }
		[XmlElement(ElementName = "NoiDung")]
		public NoiDung_D03TS NoiDung { get; set; }
	}

	[XmlRoot(ElementName = "NoiDung")]
	public class NoiDung_D03TS
	{
		[XmlElement(ElementName = "LaoDong")]
		public List<LaoDong_D03TS> LaoDong { get; set; }
	}

	[XmlRoot(ElementName = "LaoDong")]
	public class LaoDong_D03TS
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
		[XmlElement(ElementName = "MaTinhBenhVien")]
		public string MaTinhBenhVien { get; set; }
		[XmlElement(ElementName = "MaBenhVien")]
		public string MaBenhVien { get; set; }
		[XmlElement(ElementName = "NgayBienLai")]
		public string NgayBienLai { get; set; }
		[XmlElement(ElementName = "SoBienLai")]
		public string SoBienLai { get; set; }
		[XmlElement(ElementName = "Tiendong")]
		public string Tiendong { get; set; }
		[XmlElement(ElementName = "Sothang")]
		public string Sothang { get; set; }
		[XmlElement(ElementName = "Ghichu")]
		public string Ghichu { get; set; }
		[XmlElement(ElementName = "CCNS")]
		public string CCNS { get; set; }
		[XmlElement(ElementName = "PA")]
		public string PA { get; set; }
		[XmlElement(ElementName = "MavungSS")]
		public string MavungSS { get; set; }
		[XmlElement(ElementName = "MucHuong")]
		public string MucHuong { get; set; }
		[XmlElement(ElementName = "ID")]
		public string ID { get; set; }
		[XmlElement(ElementName = "Loai")]
		public string Loai { get; set; }
		[XmlElement(ElementName = "MaPhongBan")]
		public string MaPhongBan { get; set; }
		[XmlElement(ElementName = "TyleNSDP")]
		public string TyleNSDP { get; set; }
		[XmlElement(ElementName = "HotroKhac")]
		public string HotroKhac { get; set; }
		[XmlElement(ElementName = "Matinh_DangSS")]
		public string Matinh_DangSS { get; set; }
		[XmlElement(ElementName = "Mahuyen_DangSS")]
		public string Mahuyen_DangSS { get; set; }
		[XmlElement(ElementName = "Maxa_DangSS")]
		public string Maxa_DangSS { get; set; }
		[XmlElement(ElementName = "Diachi_DangSS")]
		public string Diachi_DangSS { get; set; }
		[XmlElement(ElementName = "NgayChet")]
		public string NgayChet { get; set; }
		[XmlElement(ElementName = "CoGiamChet")]
		public string CoGiamChet { get; set; }
		[XmlElement(ElementName = "TuNgay")]
		public string TuNgay { get; set; }
	}


	[XmlRoot(ElementName = "ThongTinKhac")]
	public class ThongTinKhac_D03TS
	{
		[XmlElement(ElementName = "SoTheBHYT")]
		public string SoTheBHYT { get; set; }
		[XmlElement(ElementName = "LuongCoSo")]
		public string LuongCoSo { get; set; }
		[XmlElement(ElementName = "TyleNSNN")]
		public string TyleNSNN { get; set; }
		[XmlElement(ElementName = "LoaiDoiTuong")]
		public string LoaiDoiTuong { get; set; }
		[XmlElement(ElementName = "NguonDong")]
		public string NguonDong { get; set; }
		[XmlElement(ElementName = "TenDoiTuong")]
		public string TenDoiTuong { get; set; }
		[XmlElement(ElementName = "HinhThucTinh")]
		public string HinhThucTinh { get; set; }
	}


	

	

}

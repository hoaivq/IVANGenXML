using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace IVANGenXMLService
{
	
	[XmlRoot(ElementName = "ThongTinKhac")]
	public class ThongTinKhac_D05TS
	{
		[XmlElement(ElementName = "SoSoBHXH")]
		public string SoSoBHXH { get; set; }
	}

	[XmlRoot(ElementName = "LaoDong")]
	public class LaoDong_D05TS
	{
		[XmlElement(ElementName = "STT")]
		public string STT { get; set; }
		[XmlElement(ElementName = "HoTen")]
		public string HoTen { get; set; }
		[XmlElement(ElementName = "MasoBHXH")]
		public string MasoBHXH { get; set; }
		[XmlElement(ElementName = "MucTien")]
		public string MucTien { get; set; }
		[XmlElement(ElementName = "Tuthang")]
		public string Tuthang { get; set; }
		[XmlElement(ElementName = "Sothang")]
		public string Sothang { get; set; }
		[XmlElement(ElementName = "Tongtien")]
		public string Tongtien { get; set; }
		[XmlElement(ElementName = "TienTudong")]
		public string TienTudong { get; set; }
		[XmlElement(ElementName = "TienHotro")]
		public string TienHotro { get; set; }
		[XmlElement(ElementName = "Ghichu")]
		public string Ghichu { get; set; }
		[XmlElement(ElementName = "PA")]
		public string PA { get; set; }
		[XmlElement(ElementName = "Tyle")]
		public string Tyle { get; set; }
		[XmlElement(ElementName = "TyleNSNN")]
		public string TyleNSNN { get; set; }
		[XmlElement(ElementName = "Heso")]
		public string Heso { get; set; }
		[XmlElement(ElementName = "Phuongthuc")]
		public string Phuongthuc { get; set; }
		[XmlElement(ElementName = "CCNS")]
		public string CCNS { get; set; }
		[XmlElement(ElementName = "ID")]
		public string ID { get; set; }
		[XmlElement(ElementName = "Loai")]
		public string Loai { get; set; }
		[XmlElement(ElementName = "TyleNSDP")]
		public string TyleNSDP { get; set; }
		[XmlElement(ElementName = "TienNSDP")]
		public string TienNSDP { get; set; }
		[XmlElement(ElementName = "TyleHotroKhac")]
		public string TyleHotroKhac { get; set; }
		[XmlElement(ElementName = "TienHotroKhac")]
		public string TienHotroKhac { get; set; }
		[XmlElement(ElementName = "Matinh_DangSS")]
		public string Matinh_DangSS { get; set; }
		[XmlElement(ElementName = "Mahuyen_DangSS")]
		public string Mahuyen_DangSS { get; set; }
		[XmlElement(ElementName = "Maxa_DangSS")]
		public string Maxa_DangSS { get; set; }
		[XmlElement(ElementName = "Diachi_DangSS")]
		public string Diachi_DangSS { get; set; }
	}

	[XmlRoot(ElementName = "NoiDung")]
	public class NoiDung_D05TS
	{
		[XmlElement(ElementName = "LaoDong")]
		public List<LaoDong_D05TS> LaoDong { get; set; }
	}

	[XmlRoot(ElementName = "D05-TS")]
	public class D05TS
	{
		[XmlElement(ElementName = "ThongTinKhac")]
		public ThongTinKhac_D05TS ThongTinKhac { get; set; }
		[XmlElement(ElementName = "NoiDung")]
		public NoiDung_D05TS NoiDung { get; set; }
	}

}

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace IVANGenXMLService
{
	[XmlRoot(ElementName = "ThongTin")]
	public class ThongTin
	{
		[XmlElement(ElementName = "STT")]
		public string STT { get; set; }
		[XmlElement(ElementName = "HoTen")]
		public string HoTen { get; set; }
		[XmlElement(ElementName = "MasoBHXH")]
		public string MasoBHXH { get; set; }
		[XmlElement(ElementName = "TenLoaiVanBan")]
		public string TenLoaiVanBan { get; set; }
		[XmlElement(ElementName = "SoVanBan")]
		public string SoVanBan { get; set; }
		[XmlElement(ElementName = "NgayBanHanh")]
		public DateTime NgayBanHanh { get; set; }
		[XmlElement(ElementName = "NgayHieuLuc")]
		public DateTime NgayHieuLuc { get; set; }
		[XmlElement(ElementName = "CoQuanBanHanh")]
		public string CoQuanBanHanh { get; set; }
		[XmlElement(ElementName = "TrichYeu")]
		public string TrichYeu { get; set; }
		[XmlElement(ElementName = "NoiDungThamDinh")]
		public string NoiDungThamDinh { get; set; }
	}

	[XmlRoot(ElementName = "BangKe")]
	public class BangKe
	{
		[XmlElement(ElementName = "ThongTin")]
		public List<ThongTin> ThongTin { get; set; }
	}

	[XmlRoot(ElementName = "NoiDung")]
	public class NoiDung
	{
		[XmlElement(ElementName = "TenBangKe")]
		public string TenBangKe { get; set; }
		[XmlElement(ElementName = "KemTheo")]
		public string KemTheo { get; set; }
		[XmlElement(ElementName = "BangKe")]
		public BangKe BangKe { get; set; }
	}

	[XmlRoot(ElementName = "D01-TS")]
	public class D01TS
	{
		[XmlElement(ElementName = "NoiDung")]
		public NoiDung NoiDung { get; set; }
		//[XmlElement(ElementName = "Cky")]
		//public string Cky { get; set; }
		//[XmlAttribute(AttributeName = "xsi")]
		//public string Xsi { get; set; }
		//[XmlAttribute(AttributeName = "xsd")]
		//public string Xsd { get; set; }
	}

}

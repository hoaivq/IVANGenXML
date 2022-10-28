using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace IVANGenXMLService
{
	[XmlRoot(ElementName = "ValidHoSo")]
	public class ValidHoSo
	{
		[XmlElement(ElementName = "MaThuTuc")]
		public string MaThuTuc { get; set; }
		[XmlElement(ElementName = "ListToKhaiPhaiCo")]
		public string ListToKhaiPhaiCo { get; set; }
		[XmlElement(ElementName = "ListToKhaiCoTheCo")]
		public string ListToKhaiCoTheCo { get; set; }
	}

	[XmlRoot(ElementName = "ValidHoSos")]
	public class ValidHoSos
	{
		[XmlElement(ElementName = "ValidHoSo")]
		public List<ValidHoSo> ListValidHoSo { get; set; }
	}

}

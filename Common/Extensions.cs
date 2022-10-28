using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Common
{
    public class UTF8StringWriter : StringWriter { public override Encoding Encoding { get { return Encoding.UTF8; } } }

    public static class Extensions
    {
        public static string ToXML<T>(this T ObjectToSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(ObjectToSerialize.GetType());
            using (StringWriter textWriter = new UTF8StringWriter())
            {
                xmlSerializer.Serialize(textWriter, ObjectToSerialize);
                return textWriter.ToString().Replace(" xmlns=\"http://tempuri.org/\"", "");
            }
        }

        public static T ToObject<T>(this string input) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }


        public static void ValidNode(this XmlDocument xDoc, string Path, ref StringBuilder sbMsg, bool IsValidEmpty = false, int MaxLength = -1, bool IsValidNumber = false, bool IsValidDate = false)
        {
            string Value = xDoc.SelectSingleNode(Path).InnerText;

            // Valid trường để trống
            if (IsValidEmpty)
            {
                if (string.IsNullOrWhiteSpace(Value))
                {
                    sbMsg.AppendLine("Giá trị tại thẻ " + Path + " không được để trống");
                }
            }

            // Valid độ dài trường
            if (MaxLength > 0)
            {
                if (Value.Trim().Length > MaxLength)
                {
                    sbMsg.AppendLine("Giá trị tại thẻ " + Path + " vượt quá " + MaxLength + " ký tự");
                }
            }

            // Valid kiểu số
            if (IsValidNumber)
            {
                long outNum;
                if (long.TryParse(Value, out outNum) == false)
                {
                    sbMsg.AppendLine("Giá trị tại thẻ " + Path + " phải là dữ liệu kiểu số (" + Value + ")");
                }
            }

            // Valid kiểu ngày
            if (IsValidDate)
            {
                DateTime outDate;
                if (DateTime.TryParse(Value, out outDate) == false)
                {
                    sbMsg.AppendLine("Giá trị tại thẻ " + Path + " phải là dữ liệu kiểu ngày (" + Value + ")");
                }
            }
        }

        public static void ValidNodeList(this XmlDocument xDoc, string PathLoop, string NodeName, ref StringBuilder sbMsg, bool IsValidEmpty = false, int MaxLength = -1, bool IsValidNumber = false, bool IsValidDate = false)
        {
            XmlNodeList xmlNodeList = xDoc.SelectNodes(PathLoop);
            if (xmlNodeList.Count > 0)
            {
                int nodeCnt = 1;
                foreach (XmlNode node in xmlNodeList)
                {
                    string Value = node.SelectSingleNode(NodeName).InnerText;
                    // Valid trường để trống
                    if (IsValidEmpty)
                    {
                        if (string.IsNullOrWhiteSpace(Value))
                        {
                            sbMsg.AppendLine("Giá trị tại thẻ " + PathLoop + "[" + nodeCnt + "]." + NodeName + " không được để trống");
                        }
                    }

                    // Valid độ dài trường
                    if (MaxLength > 0)
                    {
                        if (Value.Trim().Length > MaxLength)
                        {
                            sbMsg.AppendLine("Giá trị tại thẻ " + PathLoop + "[" + nodeCnt + "]." + NodeName + " vượt quá " + MaxLength + " ký tự");
                        }
                    }

                    // Valid kiểu số
                    if (IsValidNumber)
                    {
                        long outNum;
                        if (long.TryParse(Value, out outNum) == false)
                        {
                            sbMsg.AppendLine("Giá trị tại thẻ " + PathLoop + "[" + nodeCnt + "]." + NodeName + " phải là dữ liệu kiểu số (" + Value + ")");
                        }
                    }

                    // Valid kiểu ngày
                    if (IsValidDate)
                    {
                        DateTime outDate;
                        if (DateTime.TryParse(Value, out outDate) == false)
                        {
                            sbMsg.AppendLine("Giá trị tại thẻ " + PathLoop + "[" + nodeCnt + "]." + NodeName + " phải là dữ liệu kiểu ngày (" + Value + ")");
                        }
                    }

                    nodeCnt++;
                }
            }

        }
    }
}

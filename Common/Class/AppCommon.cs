using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Class
{
   public class AppCommon
    {
        public string ObjectToXML<T>(T Source)
        {
            string result = string.Empty;

            using (StringWriter writer = new StringWriter())
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                serializer.Serialize(writer, Source);
                result = writer.ToString();
            }
            return result;
        }

        public string PathCombine(params string[] Paths)
        {
            if (Paths.Length <= 0) { return string.Empty; }
            string firstPath = Paths[0];

            string filePath = string.Empty;
            bool isFirstPath = true;
            foreach (string nextPath in Paths)
            {
                if (isFirstPath) { isFirstPath = false; continue; }
                filePath = Path.Combine(filePath, nextPath);
            }

            return firstPath.TrimEnd(new char[] { '\\' }) + @"\" + filePath.TrimStart(new char[] { '\\' });
        }
    }
}

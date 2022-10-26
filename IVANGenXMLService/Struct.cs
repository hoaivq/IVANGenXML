using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IVANGenXMLService
{
    public class MsgResult
    {
        public MsgResult()
        {

        }

        public MsgResult(bool _Success, string _Message = "", string _XmlValue = "")
        {
            Success = _Success;
            Message = _Message;
            XmlValue = _XmlValue;
        }

        public MsgResult(string Title, Exception ex)
        {
            MyApp.Log.GhiLog(Title, ex);
            Success = false;
            Message = ex.Message + Environment.NewLine + ex.StackTrace;
            XmlValue = string.Empty;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public string XmlValue { get; set; }
    }
}
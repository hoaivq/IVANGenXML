using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common.Class
{
    public class AppSetting
    {
        public string AppPath
        {
            get
            {
                if (ConfigurationManager.AppSettings["AppPath"] != null)
                {
                    return ConfigurationManager.AppSettings["AppPath"].ToString();
                }
                else
                {
                    return Application.StartupPath;
                }
            }
        }

        private string _LogDir;
        public string LogDir
        {
            get
            {
                if (string.IsNullOrEmpty(_LogDir))
                {
                    _LogDir = MyApp.Common.PathCombine(AppPath, "Logs");
                }

                if (Directory.Exists(_LogDir) == false)
                {
                    Directory.CreateDirectory(_LogDir);
                }
                return _LogDir;
            }
        }

    }
}

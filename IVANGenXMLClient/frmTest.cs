using Common;
using IVANGenXMLClient.IVANGenXMLService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IVANGenXMLClient
{
    public partial class frmTest : Form
    {
        IVANGenXMLService.Service objSV = new IVANGenXMLService.Service();
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnD01_Click(object sender, EventArgs e)
        {
            try
            {
                D01TS objToKhai = new D01TS();
                objToKhai.NoiDung = new NoiDung()
                {
                    TenBangKe = "Hồ sơ làm căn cứ truy thu BHXH, BHYT, BHTN, BHTNLĐ, BNN",
                    KemTheo = "Kèm theo Báo cáo tình hình sử dụng lao động và danh sách tham gia BHXH, BHYT, BHTN, BHTNLĐ, BNN (Mẫu D02-LT); Tờ khai cung cấp và thay đổi thông tin người tham gia BHXH, BHYT (Mẫu TK1-TS)",
                    BangKe = new ThongTin[] {
                        new ThongTin(){HoTen = "Hoai" }

                    }
                };

                MsgResult msgResult = objSV.GenXML_D01(objToKhai);
                if (msgResult.Success == false)
                {
                    MessageBox.Show(msgResult.Message);
                    return;
                }
                txtKetQua.Text = msgResult.XmlValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

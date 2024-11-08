using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Kiosk.View
{
    public partial class PayResultForm : Form
    {
        public PayResultForm(string status)
        {
            InitializeComponent();

            if(status == "success")
            {
                lbl_status.Text = "결제가 완료되었습니다.";
                pic_icon.Image = Properties.Resources.check_icon;
            }
            else if(status == "fail")
            {
                lbl_status.Text = "결제에 실패했습니다.";
                pic_icon.Image = Properties.Resources.forbidden_icon;
            }
        }
    }
}

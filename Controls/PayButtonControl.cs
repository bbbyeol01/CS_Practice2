using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Kiosk.Controls
{
    public partial class PayButtonControl : UserControl
    {
        public PayButtonControl()
        {
            InitializeComponent();
        }

        public string Name
        {
            get { return lbl_name.Text; }
            set { lbl_name.Text = value; }
        }
        public Image Pic_method
        {
            set { this.pic_payMethod.Image = value;  }
        }
    }
}

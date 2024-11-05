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
    public partial class DrinkOption : UserControl
    {
        public DrinkOption()
        {
            InitializeComponent();
        }

        public string Name
        {
            get { return this.lbl_name.Text; }
            set { this.lbl_name.Text = value;  }
        }
    }
}

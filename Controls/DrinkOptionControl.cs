using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coffee_Kiosk.Model;

namespace Coffee_Kiosk.Controls
{

    public partial class DrinkOptionControl : UserControl
    {

        DrinkOption option;
        public delegate void OptionChangeHandler(DrinkOption option);
        public event OptionChangeHandler optionPlus;
        public event OptionChangeHandler optionMinus;

        public DrinkOptionControl(DrinkOption option)
        {
            InitializeComponent();
            this.option = option;
        }

        public string Name
        {
            get { return this.lbl_name.Text; }
            set { this.lbl_name.Text = value;  }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if(option.Quantity == 0)
            {
                return;
            }

            option.Quantity -= 1;
            lbl_quantity.Text = option.Quantity.ToString();
            optionMinus.Invoke(option);
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            option.Quantity += 1;
            lbl_quantity.Text = option.Quantity.ToString();
            optionPlus.Invoke(option);

        }
    }
}

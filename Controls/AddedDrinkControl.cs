using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coffee_Kiosk.Model;

namespace Coffee_Kiosk.Controls
{
    public partial class AddedDrinkControl : UserControl
    {
        public AddedDrinkControl(Drink drink)
        {
            InitializeComponent();

            lbl_name.Text = drink.Name;
        }
    }
}

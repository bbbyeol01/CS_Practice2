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

namespace Coffee_Kiosk.View
{
    public partial class SelectOptionForm : Form
    {
        Drink drink;
        public SelectOptionForm(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
        }

        private void SelectOptionForm_Load(object sender, EventArgs e)
        {
            this.lbl_name.Text = drink.Name;
            this.pic_drink.Image = drink.DrinkImage;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

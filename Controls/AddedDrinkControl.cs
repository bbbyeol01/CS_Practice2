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

        public delegate void DeleteButtonClickHandler(Drink drink);
        public event DeleteButtonClickHandler deleteBtnClick;

        Drink drink;
        public AddedDrinkControl(Drink drink)
        {
            InitializeComponent();

            this.drink = drink;
            lbl_name.Text = drink.Name;

            int totalPrice = drink.Price;
            foreach (var option in drink.Options)
            {
                totalPrice += option.Price * option.Quantity;
            }

            lbl_price.Text = $"{totalPrice.ToString("N0")}원";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            deleteBtnClick.Invoke(drink);
        }
    }
}
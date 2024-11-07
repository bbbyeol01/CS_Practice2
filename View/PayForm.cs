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
    public partial class PayForm : Form
    {

        List<Drink> drinks;
        public PayForm(List<Drink> drinks)
        {
            InitializeComponent();
            this.drinks = drinks;

            lbl_count.Text = $"총 {drinks.Count}개";

            int totalCount = 0;
            foreach (Drink drink in drinks)
            {
                totalCount += drink.Price * drink.Quantity;
                foreach (DrinkOption drinkOption in drink.Options)
                {
                    totalCount += drinkOption.Price * drinkOption.Quantity;
                }
            }

            lbl_price.Text = $"{totalCount.ToString("N0")}원";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

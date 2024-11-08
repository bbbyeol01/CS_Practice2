using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coffee_Kiosk.Controls;
using Coffee_Kiosk.Model;


namespace Coffee_Kiosk.View
{
    public partial class PayForm : Form
    {

        List<Drink> drinks;
        int totalPrice = 0;

        public PayForm(List<Drink> drinks)
        {
            InitializeComponent();
            this.drinks = drinks;

            lbl_count.Text = $"총 {drinks.Count}개";

            foreach (Drink drink in drinks)
            {
                totalPrice += drink.Price * drink.Quantity;
                foreach (DrinkOption drinkOption in drink.Options)
                {
                    totalPrice += drinkOption.Price * drinkOption.Quantity;
                }
            }

            lbl_price.Text = $"{totalPrice.ToString("N0")}원";

            PayMethod();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PayMethod()
        {

            PayButtonControl creditCard = new PayButtonControl(totalPrice);
            creditCard.Pic_method = Properties.Resources.creditcard;
            creditCard.BackColor = Color.FromArgb(30, 75, 198);
            creditCard.ForeColor = Color.White;
            creditCard.Name = "신용카드";
            creditCard.Location = new Point(50, 30);
            panel_payMethod.Controls.Add(creditCard);


            PayButtonControl applepay = new PayButtonControl(totalPrice);
            applepay.Pic_method = Properties.Resources.applepay;
            applepay.BackColor = Color.Black;
            applepay.ForeColor = Color.White;
            applepay.Name = "애플페이";
            applepay.Location = new Point(50, 100);
            panel_payMethod.Controls.Add(applepay);


            PayButtonControl kakaopay = new PayButtonControl(totalPrice);
            kakaopay.Pic_method = Properties.Resources.kakaopay;
            kakaopay.BackColor = Color.FromArgb(254, 229, 0);
            kakaopay.ForeColor = Color.Black;
            kakaopay.Name = "카카오페이";
            kakaopay.Location = new Point(50, 170);
            panel_payMethod.Controls.Add(kakaopay);


        }
    }
}

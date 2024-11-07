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

            PayMethod();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PayMethod()
        {

            PayButtonControl creditCard = new PayButtonControl();
            creditCard.Pic_method = Properties.Resources.creditcard;
            creditCard.BackColor = Color.FromArgb(30, 75, 198);
            creditCard.ForeColor = Color.White;
            creditCard.Name = "신용카드";
            creditCard.Location = new Point(50, 50);
            panel_payMethod.Controls.Add(creditCard);


            PayButtonControl applepay = new PayButtonControl();
            applepay.Pic_method = Properties.Resources.applepay;
            applepay.BackColor = Color.Black;
            applepay.ForeColor = Color.White;
            applepay.Name = "애플페이";
            applepay.Location = new Point(50, 120);
            panel_payMethod.Controls.Add(applepay);


            //PayButtonControl samsungpay = new PayButtonControl();
            //samsungpay.BackColor = Color.FromArgb(30, 75, 198);
            //samsungpay.ForeColor = Color.White;
            //samsungpay.Pic_method = Properties.Resources.samsungpay;
            //samsungpay.Name = "삼성페이";
            //samsungpay.Location = new Point(50, 140);
            //panel_payMethod.Controls.Add(samsungpay);


        }
    }
}

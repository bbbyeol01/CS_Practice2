using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coffee_Kiosk.View;
using Coffee_Kiosk.Model;

namespace Coffee_Kiosk
{
    public partial class MenuItem : UserControl
    {

        Drink drink;

        public delegate void AddDrinkHandler(Drink drink);
        public event AddDrinkHandler addDrink;

        public MenuItem(Drink drink)
        {
            InitializeComponent();

            Lbl_name = drink.Name;
            Lbl_price = $"{drink.Price.ToString("N0")}원";
            Lbl_type = drink.Type;

            this.drink = drink;
        }

        public string Lbl_name
        {
            get
            {
               return this.lbl_name.Text;
            }

            set
            {
                this.lbl_name.Text = value;
            }
        }

        public string Lbl_price
        {
            get
            {
                return this.lbl_price.Text;
            }

            set
            {
                this.lbl_price.Text = value;
            }
        }

        public Image Pic_drink
        {
            get
            {
                return this.pic_drink.Image;
            }

            set
            {
                this.pic_drink.Image = value;
            }
        }

        public string Lbl_type
        {
            get { return this.lbl_type.Text; }
            set { this.lbl_type.Text = value; }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ShadowForm shadow = new ShadowForm();
            shadow.Show();

            SelectOptionForm selectOptionForm = new SelectOptionForm(drink);
            selectOptionForm.addDrink += AddDrink;

            // shadow 창 누르면 둘 다 꺼짐
            shadow.Click += (s, args) => { 
                selectOptionForm.Dispose();
                shadow.Dispose();
            };

            // selectoptionform이 꺼지면 shadow도 꺼짐
            selectOptionForm.FormClosed += (s, args) => shadow.Dispose();
            selectOptionForm.Show();

        }

        private void AddDrink(Drink drink)
        {
            addDrink.Invoke(drink);
            this.drink.Options.Clear();
        }
    }
}

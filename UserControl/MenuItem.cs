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
        public MenuItem()
        {
            InitializeComponent();
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
            Drink drink = new Drink();
            drink.Name = Lbl_name;
            drink.Price = int.Parse(Lbl_price.Replace("원", "").Replace(",", ""));
            drink.DrinkImage = Pic_drink;

            ShadowForm shadow = new ShadowForm();
            shadow.Show();

            SelectOptionForm selectOptionForm = new SelectOptionForm(drink);

            // selectoptionform이 꺼지면 shadow가 꺼지는 이벤트
            selectOptionForm.FormClosed += (s, args) => shadow.Dispose();
            selectOptionForm.Show();

        }
    }
}

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
using Coffee_Kiosk.Repository;
using System.Net;
using System.IO;

namespace Coffee_Kiosk
{
    public partial class MenuItem : UserControl
    {

        public delegate void AddDrinkHandler(Drink drink);
        public event AddDrinkHandler addDrink;

        DrinkInfo drinkInfo;
        public MenuItem(int drinkIdx)
        {
            InitializeComponent();

            MenuRepository menuRepository = new MenuRepository();

            drinkInfo = menuRepository.getDrinkInfo(drinkIdx);

            string path = @"https://www.banapresso.com/from_open_storage?ws=fprocess&file=banapresso/menu/";

            using (WebClient webClient = new WebClient())
            {
                // URL에서 이미지 데이터를 읽어옵니다
                byte[] imageData = webClient.DownloadData($"{path}{drinkInfo.DrinkInfoImage}");

                // 이미지 데이터를 메모리 스트림으로 변환하여 Image 객체를 생성합니다
                using (var stream = new MemoryStream(imageData))
                {
                    Pic_drink = Image.FromStream(stream);

                }

            }

            Lbl_name = drinkInfo.Name;
            Lbl_price = $"{drinkInfo.Price.ToString("N0")}원";


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

            Drink drink = new Drink();
            drink.Idx = this.drinkInfo.Idx;
            drink.Name = this.drinkInfo.Name;
            drink.Price = this.drinkInfo.Price;
            drink.DrinkImage = Pic_drink;
            drink.Desc = this.drinkInfo.Description;

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
        }

    }
}

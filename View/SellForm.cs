using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Coffee_Kiosk.Repository;
using Coffee_Kiosk.View;

namespace Coffee_Kiosk
{
    public partial class SellForm : Form
    {

        MenuRepository menuRepository = new MenuRepository();
        public SellForm()
        {
            InitializeComponent();

        }

        private void btn_coffee_Click(object sender, EventArgs e)
        {
            List<(int, string, string, string, List<string>)> menuItems = menuRepository.getMenuByCategory("coffee");

            int xOffset = 0;
            int yOffset = 0;

            foreach(var (idx, name, price, image, types) in menuItems)
            {
                MenuItem menuItem = new MenuItem();
                menuItem.Lbl_name = name;
                menuItem.Lbl_price = price;

                // menuItem.Pic_drink = Properties.Resources.americano;

                string path = @"https://www.banapresso.com/from_open_storage?ws=fprocess&file=banapresso/menu/";

                using (WebClient webClient = new WebClient())
                {
                    // URL에서 이미지 데이터를 읽어옵니다
                    byte[] imageData = webClient.DownloadData($"{path}{image}");

                    // 이미지 데이터를 메모리 스트림으로 변환하여 Image 객체를 생성합니다
                    using (var stream = new MemoryStream(imageData))
                    {
                        menuItem.Pic_drink = Image.FromStream(stream);
                    }
                }

                foreach (var type in types)
                {
                    menuItem.Lbl_type += $"{type} ";
                }

                menuItem.Location = new Point(xOffset, yOffset);
                xOffset += menuItem.Width;

                if (xOffset + menuItem.Width > this.Width)
                {
                    yOffset += menuItem.Height;
                    xOffset = 0;
                }

                panel_menu.Controls.Add(menuItem);


            }



        }

    }
}

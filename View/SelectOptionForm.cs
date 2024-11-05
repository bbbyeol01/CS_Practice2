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
using Coffee_Kiosk.Repository;

namespace Coffee_Kiosk.View
{
    public partial class SelectOptionForm : Form
    {
        Drink drink;
        MenuRepository menuRepository = new MenuRepository();

        public SelectOptionForm(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
        }

        private void SelectOptionForm_Load(object sender, EventArgs e)
        {
            this.lbl_name.Text = drink.Name;
            this.pic_drink.Image = drink.DrinkImage;
            this.lbl_desc.Text = menuRepository.getDesc(drink.Idx);

            List<string> types = menuRepository.getTypes(drink.Idx);
            DrinkTypeControl drinkType = new DrinkTypeControl();
            foreach (string type in types)
            {
                if(type == "HOT")
                {
                    drinkType.Radio_hot = true;
                }
                
                if(type == "ICE")
                {
                    drinkType.Radio_ice = true;
                }
            }

            panel_type.Controls.Add(drinkType);

            List<(string, string)> options = menuRepository.getOptions();
            int yOffset = 0;
            foreach(var (name, price) in options)
            {
                DrinkOptionControl option = new DrinkOptionControl();
                option.Name = name;
                option.Location = new Point(0, yOffset);
                panel_option.Controls.Add(option);
                yOffset += option.Height;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

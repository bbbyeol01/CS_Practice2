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
        int selectDrinkPrice;

        public delegate void AddDrinkHandler(Drink drink);
        public event AddDrinkHandler addDrink;

        public SelectOptionForm(Drink drink)
        {
            InitializeComponent();
            this.drink = drink;
            this.selectDrinkPrice = drink.Price;
        }

        private void SelectOptionForm_Load(object sender, EventArgs e)
        {
            this.lbl_name.Text = drink.Name;
            this.pic_drink.Image = drink.DrinkImage;
            this.lbl_desc.Text = menuRepository.getDesc(drink.Idx);
            this.lbl_totalPrice.Text = $"{drink.Price.ToString("N0")}원";

            List<string> types = menuRepository.getTypes(drink.Idx);
            DrinkTypeControl drinkType = new DrinkTypeControl(drink);
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

            List<(string, int)> options = menuRepository.getOptions();
            int yOffset = 0;
            foreach(var (name, price) in options)
            {

                DrinkOption drinkOption = new DrinkOption();
                drinkOption.Name = name;
                drinkOption.Price = price;

                DrinkOptionControl optionControl = new DrinkOptionControl(drinkOption);
                optionControl.Name = name;
                optionControl.optionPlus += OptionPlus;
                optionControl.optionMinus += OptionMinus;

                optionControl.Location = new Point(0, yOffset);
                panel_option.Controls.Add(optionControl);
                yOffset += optionControl.Height;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OptionPlus(DrinkOption option)
        {
            selectDrinkPrice += option.Price;

            DrinkOption existOption = drink.Options.Find(addedOption => addedOption.Name == option.Name);
            if (existOption != null)
            {
                existOption.Quantity += 1;
            }
            else
            {
                option.Quantity = 1;
                drink.AddOption(option);

            }

            this.lbl_totalPrice.Text = $"{selectDrinkPrice.ToString("N0")}원";

        }

        public void OptionMinus(DrinkOption option)
        {
            if(option.Quantity == 0)
            {
                return;
            }
            selectDrinkPrice -= option.Price;

            if (option.Quantity == 1)
            {
                drink.DeleteOption(option);
                option.Quantity = 0;
                return;
            }

            DrinkOption existOption = drink.Options.Find(addedOption => addedOption.Name == option.Name);
            if (existOption != null)
            {
                existOption.Quantity -= 1;
            }

            this.lbl_totalPrice.Text = $"{selectDrinkPrice.ToString("N0")}원";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addDrink.Invoke(drink);
            this.Close();
        }
    }
}

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
using Coffee_Kiosk.Model;
using Coffee_Kiosk.Controls;

namespace Coffee_Kiosk
{
    public partial class SellForm : Form
    {
        List<Button> buttons = new List<Button>();
        MenuRepository menuRepository = new MenuRepository();

        List<Drink> drinks = new List<Drink>();

        public SellForm()
        {
            InitializeComponent();

            buttons.Add(btn_coffee);
            buttons.Add(btn_nonCoffee);
            buttons.Add(btn_teaAndAde);
            buttons.Add(btn_smootie);

            //panel_category.Left -= 50;
            // 마우스 휠 이벤트 연결
            panel_category.MouseWheel += (s, e) =>
            {
                int scrollAmount = 20; // 스크롤 이동 양

                if(e.Delta > 0 && panel_category.Left == 0)
                {
                    return;
                }

                if (e.Delta < 0 && panel_category.Right <= this.Width)
                {
                    return;

                }

                panel_category.Left += e.Delta > 0 ? scrollAmount : -scrollAmount;


            };


        }

        private void SellForm_Load(object sender, EventArgs e)
        {
            List<DrinkInfo> menuItems = menuRepository.getMenuByCategory("coffee");
            MenuPrint(menuItems);

        }

        private void btn_coffee_Click(object sender, EventArgs e)
        {
            List<DrinkInfo> menuItems = menuRepository.getMenuByCategory("coffee");
            SelectedMenuBtn(sender as Button);
            MenuPrint(menuItems);
        }

        private void btn_nonCoffee_Click(object sender, EventArgs e)
        {
            List<DrinkInfo> menuItems = menuRepository.getMenuByCategory("noncoffee");
            SelectedMenuBtn(sender as Button);
            MenuPrint(menuItems);
        }

        private void btn_teaAndAde_Click(object sender, EventArgs e)
        {
            List<DrinkInfo> menuItems = menuRepository.getMenuByCategory("tea");
            SelectedMenuBtn(sender as Button);
            MenuPrint(menuItems);
        }

        private void btn_smootie_Click(object sender, EventArgs e)
        {
            List<DrinkInfo> menuItems = menuRepository.getMenuByCategory("smootie");
            SelectedMenuBtn(sender as Button);
            MenuPrint(menuItems);
        }

        private void MenuPrint(List<DrinkInfo> drinkInfoList)
        {
            panel_menu.Controls.Clear();
            int xOffset = 0;
            int yOffset = 0;

            foreach (DrinkInfo drinkInfo in drinkInfoList)
            {
                //Drink drink = new Drink();
                //drink.Idx = drinkInfo.Idx;
                //drink.Name = drinkInfo.Name;
                //drink.Price = drinkInfo.Price;
                //drink.Category = drinkInfo.Category;

                MenuItem menuItem = new MenuItem(drinkInfo.Idx);
                //menuItem.Lbl_name = drink.Name;
                //menuItem.Lbl_price = $"{drink.Price.ToString("N0")}원";
                menuItem.addDrink += AddDrink;

                // menuItem.Pic_drink = Properties.Resources.americano;


                foreach (string type in drinkInfo.Types)
                {
                    menuItem.Lbl_type += $"{type} ";
                }

                menuItem.Location = new Point(xOffset, yOffset);
                xOffset += menuItem.Width;

                if (xOffset + menuItem.Width >= this.Width)
                {
                    yOffset += menuItem.Height;
                    xOffset = 0;
                }

                panel_menu.Controls.Add(menuItem);


            }
        }

        private void SelectedMenuBtn(Button ClickedBtn)
        {
            foreach(Button btn in buttons)
            {
                if(btn == ClickedBtn)
                {
                    btn.BackColor = Color.CornflowerBlue;
                    btn.ForeColor = Color.White;
                    continue;
                }

                btn.BackColor = Color.White;
                btn.ForeColor = Color.FromArgb(0, 0, 5, 85);
            }
        }

        int listYOffset = 0;
        int height = 40;
        private void AddDrink(Drink drink)
        {
            //Drink existDrink = drinks.Find(addDrink => addDrink.Equals(drink));
            //if(existDrink != null)
            //{
                //existDrink.Quantity += 1;
                // AddedDrinkControl 수량 수정하는 코드
            //}
            //else
            //{
                
                this.drinks.Add(drink);
                AddedDrinkControl addedDrinkControl = new AddedDrinkControl(drink);
                addedDrinkControl.deleteBtnClick += deleteDrink;
                addedDrinkControl.Location = new Point(0, listYOffset);
                panel_list.Controls.Add(addedDrinkControl);

                listYOffset += height;

            //}

            int totalPrice = 0;
            int totalCount = 0;
            foreach(Drink addedDrink in drinks)
            {
                totalCount += addedDrink.Quantity;
                totalPrice += addedDrink.Price * addedDrink.Quantity;
                foreach(DrinkOption addedOption in addedDrink.Options)
                {
                    totalPrice += addedOption.Price * addedOption.Quantity;
                }
            }

            lbl_quantity.Text = $"{totalCount}개";
            lbl_totalPrice.Text = $"{totalPrice.ToString("N0")}원";

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            ShadowForm shadow = new ShadowForm();
            PayForm payForm = new PayForm(drinks);

            // shadow 창 누르면 둘 다 꺼짐
            shadow.Click += (s, args) => {
                payForm.Dispose();
                shadow.Dispose();
            };

            // selectoptionform이 꺼지면 shadow도 꺼짐
            payForm.FormClosed += (s, args) => shadow.Dispose();

            shadow.Show();
            payForm.Show();

        }
        
        public void deleteDrink(Drink drink)
        {
            drinks.Remove(drinks.Find((otherDrink) => drink.Equals(otherDrink)));
        }
    }
}

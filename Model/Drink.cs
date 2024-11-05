using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Kiosk.Model
{
    public class Drink
    {
        
        
        public Drink()
        {

        }

        public int Idx
        {
            get; set;
        }
        
        public string Name 
        {
            get; set;
        }

        // 순 음료 가격
        public int Price 
        {
            get; set; 
        }

        // HOT/ICE
        public string Type
        {
            get; set;
        }

        public List<DrinkOption> Options = new List<DrinkOption>();

        public Image DrinkImage
        {
            get; set;
        }

        public int Quantity
        {
            get; set;
        }

        public void AddOption(DrinkOption option)
        {
            this.Options.Add(option);
        }

        public void DeleteOption(DrinkOption option)
        {
            //this.Options.Remove(option);
            this.Options.RemoveAll(addedOption => option.Name == addedOption.Name);
        }
    }
}

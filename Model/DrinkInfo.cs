using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Kiosk.Model
{
    public class DrinkInfo
    {

        public DrinkInfo()
        {
        }

        public DrinkInfo(int idx, string name, int price, string drinkInfoImage, string category, List<string> types)
        {
            Idx = idx;
            Name = name;
            Price = price;
            DrinkInfoImage = drinkInfoImage;
            Category = category;
            Types = types;
        }

        public int Idx
        {
            get; set;
        }

        public String Name
        {
            get; set;
        }

        public int Price
        {
            get; set;
        }

        public string DrinkInfoImage
        {
            get; set;
        }

        public List<string> Types
        {
            get; set;
        }

        public string Category
        {
            get; set;
        }


       
    }
}

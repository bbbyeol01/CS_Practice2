using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Kiosk.Model
{
    public class DrinkOption
    {

        public DrinkOption()
        {

        }

        public string Name
        {
            get; set;
        }

        public int Price
        {
            get; set;
        }

        public int Quantity
        {
            get; set;
        }

        public override bool Equals(object obj)
        {
            if (obj is DrinkOption otherOption)
            {
                return this.Name == otherOption.Name && this.Quantity == otherOption.Quantity;
            }
            return false;
        }

    }
}

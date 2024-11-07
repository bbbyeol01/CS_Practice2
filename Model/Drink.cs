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
            this.Quantity = 1;
        }

        public Drink(Drink otherDrink)
        {
            Idx = otherDrink.Idx;
            Name = otherDrink.Name;
            Price = otherDrink.Price;

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

        public string Category
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

        public string Desc
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

        public override bool Equals(object obj)
        {
            Drink otherDrink = (Drink)obj;

            // 이름과 타입 비교
            if (this.Name != otherDrink.Name || this.Type != otherDrink.Type)
                return false;

            // 옵션 수가 동일한지 확인
            if (this.Options.Count != otherDrink.Options.Count)
                return false;

            // 각 옵션을 비교
            for (int i = 0; i < this.Options.Count; i++)
            {
                if (this.Options[i].Name != otherDrink.Options[i].Name ||
                    this.Options[i].Quantity != otherDrink.Options[i].Quantity)
                {
                    return false;
                }
            }

            return true; // 모든 비교를 통과하면 true 반환
        }
    }
}

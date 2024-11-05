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

        // 옵션까지 추가된 총 가격
        public int Price 
        {
            get; set; 
        }
        public string Type
        {
            get; set;
        }
        public List<string> Options
        {
            get; set;
        }

        public Image DrinkImage
        {
            get; set;
        }

        public void AddOption(string option)
        {
            this.Options.Add(option);
        }
    }
}

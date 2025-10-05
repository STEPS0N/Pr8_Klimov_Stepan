using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;

namespace Shop_Климов.Classes
{
    public class Shop
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; } = "/Images/ic_item.png";
        public Shop(string Name, int Price, string Image)
        {
            this.Name = Name;
            this.Price = Price;
            this.Image = Image;
        }
    }
}

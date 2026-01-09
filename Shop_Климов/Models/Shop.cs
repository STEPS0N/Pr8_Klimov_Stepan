using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;

namespace Shop_Климов.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public string Image { get; set; } = "/Images/ic_item.png";

        public Shop() { }

        public Shop(int Id, string Name, int Price, int Discount)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Discount = Discount;
        }

        //Конструктор для изображения
        public Shop(int Id, string Name, int Price, int Discount, string Image) : this(Id, Name, Price, Discount)
        {
            this.Image = Image;
        }
    }
}

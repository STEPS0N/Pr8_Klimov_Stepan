using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Климов.Models
{
    public class Children : Shop
    {
        public int Age { get; set; }
        public int IdShop { get; set; }
        public Children() { }
        public Children(int Id, string Name, int Price, int Discount, int Age, int IdShop) : base(Id, Name, Price, Discount)
        {
            this.Age = Age;
            this.IdShop = IdShop;
        }
    }
}

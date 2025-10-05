using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Климов.Classes
{
    public class Children : Shop
    {
        public int Age { get; set; }
        public Children(string Name, int Price, string Image, int Age) : base(Name, Price, Image)
        {
            this.Age = Age;
        }
    }
}

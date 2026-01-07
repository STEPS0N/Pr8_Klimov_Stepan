using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Климов.Models
{
    public class Electronics : Shop
    {
        public int Battery_capacity { get; set; }
        public string Processor { get; set; }
        public int IdShop { get; set; }
        public Electronics() { }

        public Electronics(int Id, string Name, int Price, int Battery_capacity, string Processor, int IdShop) : base (Id ,Name, Price)
        {
            this.Battery_capacity = Battery_capacity;
            this.Processor = Processor;
            this.IdShop = IdShop;
        }
    }
}

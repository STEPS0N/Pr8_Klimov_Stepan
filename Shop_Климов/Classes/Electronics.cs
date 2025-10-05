using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Климов.Classes
{
    public class Electronics : Shop
    {
        public int Battery_capacity { get; set; }
        public string Processor { get; set; }

        public Electronics(string Name, int Price, string Image, int Battery_capacity, string Processor) : base (Name, Price, Image)
        {
            this.Battery_capacity = Battery_capacity;
            this.Processor = Processor;
        }
    }
}

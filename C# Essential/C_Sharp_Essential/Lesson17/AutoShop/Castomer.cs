using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShop
{
    class Castomer
    {

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public Castomer(string name, string phone, string brand, string model)
        {
            Name = name;
            Phone = phone;
            Brand = brand;
            Model = model;
        }
    }
}

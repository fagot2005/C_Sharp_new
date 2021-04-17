using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Prise { get; set; }

        public Item(int id, string name, double prise)
        {
            Id = id;
            Name = name;
            Prise = prise;
        }

    }
}

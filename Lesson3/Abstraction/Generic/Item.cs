using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Item<T> where T : new()
    {
        public static T FactoryMetod()
        {
            return new T();
        }
    }
}

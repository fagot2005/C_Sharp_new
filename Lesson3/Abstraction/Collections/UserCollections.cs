using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class UserCollections : IEnumerable, IEnumerator
    {
        Item[] itemsArray = null;

        public UserCollections()
        {
            itemsArray = new Item[4];
            itemsArray[0] = new Item(1, "Milk", 12.2);
            itemsArray[1] = new Item(2, "Orange", 15.0);
            itemsArray[2] = new Item(3, "Bread", 4.8);
            itemsArray[3] = new Item(4, "Tomato", 42.2);

        }

        int pos = -1;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }

        public bool MoveNext()
        {
            if (pos < itemsArray.Length - 1)
            {
                pos++;
                return true;
            }
            else return false;
        }

        public object Current
        {
            get
            {
                return itemsArray[pos];
            }
        }


        public void Reset()
        {
            pos = -1;
        }
    }
}

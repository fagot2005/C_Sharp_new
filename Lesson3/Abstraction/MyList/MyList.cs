using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class MyList<T>
    {
        T[] array = null;

        public MyList()
        {
            array = new T[0];
        }

        public int Count { get { return array.Length; }}

        public void Add(T elem)
        {
            if (poss == array.Length - 1)
            {

                T[] arr = new T[array.Length + 1];
                array.CopyTo(arr, 0);
                array = arr;
                poss++;
                array[poss] = elem;

            }
            else
            {
                poss++;
                array[poss] = elem;
            }
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
        }

        int poss = -1;

        public void Reset()
        {
            poss = -1;
            array = new T[0];
        }

        public IEnumerator<T> GetEnumerator()
        {
            poss = -1;
            while (true)
            {
                if (poss < array.Length - 1)
                {
                    poss++;
                    yield return array[poss];
                }
                else
                {
                    //Reset();
                    yield break;
                }
            }


        }
    }
}

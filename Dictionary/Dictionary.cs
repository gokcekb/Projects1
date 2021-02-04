using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class Dictionary<T>
    {
        T[] items;
        public Dictionary()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;  // gecici dizi

            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomList<T>
    {
        private int capacity = 4;
        private int count = 0;
        //T value;
        T[] items = new T[capacity];

        // Define the indexer to allow client code to use [] notation.
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }


        private int Count
        {
            get { return count; }
        }
        //Define method to add to end of array and/or to increase array size, if needed.
        public void Add(T value)
        {
            if (count > capacity)
            {
                T[] temp = new T[capacity * 2];

                for (int i = 0; i < count; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;
                count++;
                //items[0] = value;
            }
        }
    }
}


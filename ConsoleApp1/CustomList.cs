using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomList<T>
    {
        string value;
        T[] items = new T[2];
        int count;

        // Define the indexer to allow client code to use [] notation.
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }
        public void Add(T value)
        {

            //items[1] = 
            items[0] = value;
            //for (int i = 0; )

            //this.items[1] = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomList<T>
    {
        private T[] items;
        private int count;
        private int capacity;
       // CustomList<T> customList;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public CustomList()  //Constructor for CustomList
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
            
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index <= Count)
                {
                    return items[index];
                }
                return items[index];
            }
            set
            {
                if (index >= 0 && index <= Count)
                {
                    items[index] = value;
                }
            }
        }



        public void Add(T itemToAdd)
        {
            T[] itemsAdded = new T[count + 1];
            for (int i = 0; i < count; i++)
            {
                itemsAdded[i] = items[i];
            }

            if (capacity < count * 2)
            {
                capacity = capacity * 2;
            }
            items = itemsAdded;
            items[count] = itemToAdd;
            count += 1;
        }

        // Working on Remove method, would like to use Add method created above, not sure how to do that.
        public void RemoveAll(T itemToRemove)
        {
            T[] tempList = new T[100];
            for (int i = 0, j = 0; i < this.count; i++, j++)
            {
                if (!items[i].Equals(itemToRemove))
                {
                    tempList[j]=items[i];
                    
                }
                else
                {
                    j--;
                    count--;
                }
            }
            items = tempList;
        }

        public void Remove(T itemToRemove)
        {
            T[] tempList = new T[100];
            for (int i = 0, j = 0; i < this.count; i++, j++)
            {
                if (!items[i].Equals(itemToRemove))
                {
                    tempList[j] = items[i];

                }
                else
                {
                    j--;
                    count--;
                }
            }
            items = tempList;
        }

    }
}
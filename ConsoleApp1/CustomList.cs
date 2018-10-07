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
        bool x;
        

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
        public void xRemoveAll(T itemToRemove)
        {
            T[] tempList = new T[capacity];
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

        public CustomList<T> Zip(CustomList<T> a)
        {
            int s = (count <= a.count) ? count : a.count;
            CustomList<T> z = new CustomList<T>();
            for (int i = 0; i < s; i++)
            {
                z.Add(items[i]);
                z.Add(a[i]);
            }
            return z;
        }

        public bool Remove(T item)
        {
            T[] newitems = new T[count - 1];
            x = false;
            x = HasOneItemInList(x, newitems, items, item);
            for (int i = 0; i < count - 1; i++)
            {
                x = FindEqualItem(item, i);
                if (x == true)
                {
                    count--;
                    SetTempList(i, newitems);
                    newitems[i] = items[i + 1];
                    break;
                }
                else
                {
                    newitems[i] = items[i];
                }
            }
            items = newitems;
            return x;
        }

        private void SetTempList(int i, T[] tempItems)
        {
            for (int j = i; j < count; j++)
            {
                tempItems[j] = items[j + 1];
            }
        }

        private bool HasOneItemInList(bool y, T[] tempItems, T[] tempItems2, T item)
        {
            if (count == 1 && HasFoundItem(item))
            {
                count--;
                tempItems = tempItems2;
                return y;
            }
            return y;
        }

        public bool HasFoundItem(T item)
        {
            if (items[0].Equals(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool FindEqualItem(T item, int i)
        {

            if (items[i].Equals(item))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static CustomList<T> operator +(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> operatorList = new CustomList<T>();
            for (int i = 0; i < a.count; i++)
            {
                operatorList.Add(a[i]);
            }
            for (int i = 0; i < b.count; i++)
            {
                operatorList.Add(b[i]);
            }
            return operatorList;
        }

        public static CustomList<T> operator -(CustomList<T> a, CustomList<T> b)
        {
            CustomList<T> operatorList = new CustomList<T>();
            bool c = true;
            for (int i = 0; i < a.count; i++)
            {
                for (int j = 0; j < b.count; j++)
                {
                    if (a[i].Equals(b[j]))
                    {
                        c = false;
                        break;
                    }
                }
                if (c == true)
                {
                    operatorList.Add(a[i]);
                }
                c = true;
            }
            return operatorList;
        }

        public void SortAscending()  //Using bubble sort algorithm by comparing adjacent elements and swapping
                                     //them, so that largest sinks to bottom and smallest floats to top.
        {
            bool st = true;
            for (int i = 0; i <= (count - 1) && st; i++)
            {
                st = false;
                for (int j = 0; j < (count - 1); j++)
                {
                    if (ConvertItemToString(items[j], items[j + 1]) > 0)
                    {
                        T tempitems = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = tempitems;
                        st = true;
                    }
                }
            }
        }

        public int ConvertItemToString(T listItem1, T listItem2)
        {
            string i1 = Convert.ToString(listItem1);
            string i2 = Convert.ToString(listItem2);
            int result = CompareStringSizes(i1, i2);
            return result;
        }

        private int CompareStringSizes(string item1, string item2)
        {
            int result = item1.CompareTo(item2);
            return result;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                output.Append(items[i].ToString());

                if (i != (count - 1))
                {
                    output.Append(".");
                }
            }
            return output.ToString();
        }

    }
}

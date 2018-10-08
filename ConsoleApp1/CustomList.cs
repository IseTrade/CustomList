using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp1
{
    public class CustomList<T> : IEnumerable
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

        
        public void RemoveAll(T itemToRemove)  //Remove all instances of a matched value
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

        public CustomList<T> Zip(CustomList<T> list2)
        {
            int s = (count <= list2.count) ? count : list2.count;
            CustomList<T> zipList = new CustomList<T>();
            for (int i = 0; i < s; i++)
            {
                zipList.Add(items[i]);
                zipList.Add(list2[i]);
            }
            return zipList;
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

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> operatorList = new CustomList<T>();
            for (int i = 0; i < list1.count; i++)
            {
                operatorList.Add(list1[i]);
            }
            for (int i = 0; i < list2.count; i++)
            {
                operatorList.Add(list2[i]);
            }
            return operatorList;
        }


        public void SortAscending()  //Using bubble sort algorithm by comparing adjacent elements and swapping
                                     //them, so that largest sinks to bottom and smallest floats to top.
                                     //really need to refactor this...
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



        //public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        //{
        //    CustomList<T> operatorList = new CustomList<T>();
        //    for (int i = 0; i < list1.count; i++)
        //    {
        //        //if the first list contains items in the second list
        //        operatorList.Remove(list1[i]);
        //        //else
        //        operatorList.Add(list1[i]);
        //        //then
        //        return operatorList;
        //    }
        //}






        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < count; index++)
            {
                yield return items[index];
            }
        }

        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> operatorList = new CustomList<T>();
            bool c = true;
            for (int i = 0; i < list1.count; i++)
            {
                c = FindItemInList(list1, list2, operatorList, c, i);
            }
            return operatorList;
        }

        private static bool FindItemInList(CustomList<T> list1, CustomList<T> list2, CustomList<T> operatorList, bool c, int i)
        {
            for (int j = 0; j < list2.count; j++)
            {
                if (list1[i].Equals(list2[j]))
                {
                    c = false;
                    break;
                }
            }
            if (c == true)
            {
                operatorList.Add(list1[i]);
            }
            c = true;
            return c;
        }





    }
}

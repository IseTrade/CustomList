using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {      
        
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> tempList = new CustomList<int>();
            customList.Add(0);
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            customList.Add(7);
            customList.Add(8);
            customList.Add(9);
            customList.Add(10);
            customList.Add(11);
            customList.Add(12);
            customList.Add(13);
            customList.Add(1);
            customList.Add(15);
            customList.Add(16);
            customList.Add(17);
            customList.Add(18);
            for (int i = 0; i < customList.Count ; i++)
            {
                Console.WriteLine(customList[i]);
            }
            Console.ReadKey();



            for (int i = 0; i < customList.Count; i++)
            {
                if (customList[i] != (10))
                {
                    tempList.Add(customList[i]);
                }               
            }

            for (int i = 0; i < tempList.Count; i++)
            {
                Console.WriteLine(tempList[i]);
            }
            Console.ReadKey();
        }
       
    }
}

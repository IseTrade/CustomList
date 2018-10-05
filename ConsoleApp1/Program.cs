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
            // Generating a big list for customList for testing purposes.
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
            Console.WriteLine($"Count is {customList.Count} \n");
            Console.ReadKey();


            // Removing item with value 10 from the list generated above then print new list to screen.
            // Might need to make sure it doesn't remove all values of 10, so maybe need another counter like
            // j++, and tell the loop to stop searching if j == 1
            // This is the "REMOVE" procedure I would like to implement in CustomList.cs as a method. 
            for (int i = 0; i < customList.Count; i++)
            {
                if (customList[i] != 10)
                {
                    tempList.Add(customList[i]);
                }               
            }

            for (int i = 0; i < tempList.Count; i++)
            {
                Console.WriteLine(tempList[i]);               
            }
            Console.WriteLine($"Count is now {tempList.Count} \n");
            Console.ReadKey();  //Notice that 10 is missing from the new list and the count is now 1 less.


            
        }
       
    }
}

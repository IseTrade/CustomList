using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
namespace CustomListUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddIntReturnsValueAtIndex0()   
            //Testing to see if value passed to customList.Add is the same as value 
            //stored at index 0 of customList.
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;

            //Act         
            customList.Add(value);

            //Assert
            Assert.AreEqual(value, customList[0]);
        }

        [TestMethod]
        public void AddIntReturnsValueAtIndex1()  
            //Testing to see if an actual integer is passed and stored correctly. 
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();           

            //Act
            customList.Add(16);
            customList.Add(5);
            //Assert

            Assert.AreEqual(5, customList[1]);
        }

        [TestMethod]
        public void AddNegativeIntReturnsValueAtIndex()  
            //Test passing a negative int.
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(-16);

            //Assert

            Assert.AreEqual(-16, customList[0]);
        }

        [TestMethod]
        public void AddStringVerifyValueAtIndex()  
            //Test passing a string
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string value = "Hello World!!!";

            //Act
            customList.Add(value);

            //Assert
            Assert.AreEqual(value, customList[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void AddStringReturnsIndexOfOutRangeException()  
            //Testing out of index range exception
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string value = "Cookie";

            //Act
            customList.Add(value);
            string temp = customList[6];
        }

        [TestMethod]
        public void IndexIntReturnsValue1()    
            //Testing to see if index works on [1]
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();          
            int value = 16;
            int value1 = 20;

            //Act
            customList.Add(value);
            customList.Add(value1);

            //Assert
            Assert.AreEqual(20, customList[1]);
        }

        [TestMethod]
        public void IndexIntReturnsValue2()    
            //Checking for value at index 0
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 20;

            //Act
            customList.Add(value);
            customList.Add(value1);

            //Assert
            Assert.AreEqual(16, customList[0]);
        }

        [TestMethod]
        public void IndexStringReturnsValue1()    
            //Checking for value at index 0 as a string
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string value = "Hello";
            string value1 = "World";

            //Act
            customList.Add(value);
            customList.Add(value1);

            //Assert
            Assert.AreEqual("Hello", customList[0]);
        }

        [TestMethod]
        public void IndexStringReturnsValue2()    
            //Checking for value at index 1 as a string
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string value = "Hello";
            string value1 = "World";

            //Act
            customList.Add(value);
            customList.Add(value1);

            //Assert
            Assert.AreEqual("World", customList[1]);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexStringReturnsOutOfIndexRangeException()  
            //Checking for out of range index
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string value = "Hello";
            string value1 = "World";

            //Act
            customList.Add(value);
            customList.Add(value1);
            string temp = customList[2];
        }

        [TestMethod]
        public void AddIntReturnsCount()    
            //Count test before doubling Array [4]
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(0);
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);

            //Assert
            Assert.AreEqual(4, customList.Count);
        }

        [TestMethod]
        public void AddIntReturnsCountAfterDoublingArraySize()    
            //Count test at 1st doubling Array[8]
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>(); 

            //Act
            customList.Add(0);
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);

            //Assert
            Assert.AreEqual(7, customList.Count);
        }

        [TestMethod]
        public void AddIntReturnsCountAfter2ndDoublingArraySize()    
            //Count test at 2nd doubling Array[16]
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();   

            //Act
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

            //Assert
            Assert.AreEqual(12, customList.Count);
        }

        [TestMethod]
        public void AddIntReturnsCountAfter3rdDoublingArraySize()    
            // Count test at 3rd doubling or array[32]
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            //Act
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
            customList.Add(10);
            customList.Add(15);
            customList.Add(16);
            customList.Add(17);
            customList.Add(18);

            int count = customList.Count;
            //Assert
            Assert.AreEqual(19, count);
        }

        [TestMethod]
        public void RemoveOneElementReturnsDecreasedCountSize() 
            //Removing one element would decrease total count by 1.
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(0);
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            customList.Remove(4);
            //Assert
            Assert.AreEqual(6, customList.Count);
        }

        [TestMethod]
        public void RemoveOnlyFirstMatchedElementReturnsCorrectValueForIndex() 
            //Removing only the first 4 in the list. 
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(0);
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(4);
            customList.Add(6);
            customList.Remove(4);

            //Assert
            Assert.AreEqual(6, customList[5]);
        }

        [TestMethod]
        public void RemoveOnlyTheFirstMatch() 
            //Making sure both 4's are not removed. 
        { 
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(0);
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(4);
            customList.Add(6);
            customList.Remove(4);
            //Assert
            Assert.AreEqual(4, customList[4]);
        }

        [TestMethod]
        public void RemoveOneElementReturnsFirstElement() 
            //Checking other elements in the list 
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(0);
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(4);
            customList.Add(6);
            customList.Remove(4);
            //Assert
            Assert.AreEqual(0, customList[0]);
        }

        [TestMethod]
        public void RemoveOneElementReturns4thElement() 
            //Checking other elements in the list 
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(0);
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(4);
            customList.Add(6);
            customList.Remove(4);
            //Assert
            Assert.AreEqual(3, customList[3]);
        }

        [TestMethod]
        public void RemoveTwoElementsReturns4thElement() 
            //Removing 2 elements and check if 4th is correct. 
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(0);
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(4);
            customList.Add(6);
            customList.Remove(4);
            customList.Remove(0);
            //Assert
            Assert.AreEqual(6, customList[4]);
        }

        [TestMethod]
        public void ZipTwoListsReturnsCountOfNewList()   
            //Zipping two lists of equal size together. 
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            //Act
            customList.Add(0);
            customList.Add(2);
            customList.Add(4);
            customList.Add(6);
            customList2.Add(1);
            customList2.Add(3);
            customList2.Add(5);
            customList2.Add(7);
            CustomList<int> zipList = customList.Zip(customList2);

            //Assert
            Assert.AreEqual(7, zipList[7]);
        }

        [TestMethod]
        public void ZipTwoListsReturns3rdElementOfNewList()   
            //Zipping two lists of equal size together. 
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            //Act
            customList.Add(0);
            customList.Add(2);
            customList.Add(4);
            customList.Add(6);
            customList2.Add(1);
            customList2.Add(3);
            customList2.Add(5);
            customList2.Add(7);  //result {0 1 2 3 4 5 6 7}
            CustomList<int> zipList = customList.Zip(customList2);

            //Assert
            Assert.AreEqual(2, zipList[2]);
        }

        [TestMethod]
        public void ZipTwoListsReturns2ndElementOfNewList()   
            //Zipping two lists of equal size together. 
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            //Act
            customList.Add(0);
            customList.Add(2);
            customList.Add(4);
            customList.Add(6);
            customList2.Add(1);
            customList2.Add(3);
            customList2.Add(5);
            customList2.Add(7);
            CustomList<int> zipList = customList.Zip(customList2);

            //Assert
            Assert.AreEqual(1, zipList[1]);
        }

        [TestMethod]
        public void ZipTwoListsReturns6thElementOfNewList()   
            //Zipping two lists of equal size together. 
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            //Act
            customList.Add(0);
            customList.Add(2);
            customList.Add(4);
            customList.Add(6);
            customList2.Add(1);
            customList2.Add(3);
            customList2.Add(5);
            customList2.Add(7);
            CustomList<int> zipList = customList.Zip(customList2);

            //Assert
            Assert.AreEqual(5, zipList[5]);
        }

        [TestMethod]
        public void ZipAddingDifferentSizedListsReturnsNewListCount()   
            //Zipping two lists of different size together. Not Working...
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            //Act
            customList.Add(0);
            customList.Add(2);
            customList.Add(4);
            customList.Add(6);
            customList2.Add(1);
            customList2.Add(3);
            customList2.Add(5);
            customList2.Add(7);
            customList2.Add(9);
            CustomList<int> zipList = customList.Zip(customList2);

            //Assert
            Assert.AreEqual(7, zipList[7]);
        }

        [TestMethod]
        public void OverLoadPlusTwoListsReturnsValueForIndex5()  
            //Overloading + Operator
        {
            //Arrange
            //CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            //Act
            customList1.Add(1);
            customList1.Add(2);
            customList1.Add(3);
            customList1.Add(4);
            customList2.Add(5);
            customList2.Add(6);
            customList2.Add(7);
            customList2.Add(8);
            CustomList<int> overLoadPlus = customList1 + customList2;

            //Assert
            Assert.AreEqual(6, overLoadPlus[5]);
        }

        [TestMethod]
        public void OverLoadPlusTwoListsReturnsValueForIndex1()  //Overloading + Operator
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            //Act
            customList1.Add(1);
            customList1.Add(2);
            customList1.Add(3);
            customList1.Add(4);
            customList2.Add(5);
            customList2.Add(6);
            customList2.Add(7);
            customList2.Add(8);
            CustomList<int> overLoadPlus = customList1 + customList2;
            //result 1 2 3 4 5 6 7 8

            //Assert
            Assert.AreEqual(2, overLoadPlus[1]);
        }

        [TestMethod]
        public void OverLoadPlusTwoListsReturnsValueForIndex4()  //Overloading + Operator
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            //Act
            customList1.Add(1);
            customList1.Add(2);
            customList1.Add(3);
            customList1.Add(4);
            customList2.Add(5);
            customList2.Add(6);
            customList2.Add(7);
            customList2.Add(8);
            CustomList<int> overLoadPlus = customList1 + customList2;

            //Assert
            Assert.AreEqual(5, overLoadPlus[4]);
        }

        [TestMethod]
        public void OverLoadPlusTwoListsReturnsValueForIndex6()  //Overloading + Operator
        {
            //Arrange

            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            //Act
            customList1.Add(1);
            customList1.Add(2);
            customList1.Add(3);
            customList1.Add(4);
            customList2.Add(5);
            customList2.Add(6);
            customList2.Add(7);
            customList2.Add(8);
            CustomList<int> overLoadPlus = customList1 + customList2;

            //Assert
            Assert.AreEqual(7, overLoadPlus[6]);
        }

        [TestMethod]
        public void OverLoadPlusTwoListsReturnsValueForIndex7()  //Overloading + Operator
        {
            //Arrange

            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            //Act
            customList1.Add(1);
            customList1.Add(2);
            customList1.Add(3);
            customList1.Add(4);
            customList2.Add(5);
            customList2.Add(6);
            customList2.Add(7);
            customList2.Add(8);
            CustomList<int> overLoadPlus = customList1 + customList2;

            //Assert
            Assert.AreEqual(8, overLoadPlus[7]);
        }

        [TestMethod]
        public void OverLoadMinusTwoListsReturnsValueAtIndex1()  //Overloading - Operator
        {
            //Arrange

            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            //Act
            customList1.Add(1);
            customList1.Add(2);
            customList1.Add(3);
            customList2.Add(4);
            customList2.Add(1);
            customList2.Add(6);

            CustomList<int> overLoadMinus = customList1 - customList2; // result 2 3

            //Assert
            Assert.AreEqual(3, overLoadMinus[1]);
        }

        [TestMethod]
        public void OverLoadMinusTwoListsReturnsValueAtIndex0()  //Overloading - Operator
        {
            //Arrange

            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            //Act
            customList1.Add(1);
            customList1.Add(2);
            customList1.Add(3);
            customList2.Add(4);
            customList2.Add(1);
            customList2.Add(6);

            CustomList<int> overLoadMinus = customList1 - customList2;  //result 2 3

            //Assert
            Assert.AreEqual(2, overLoadMinus[0]);
        }

        [TestMethod]
        public void OverLoadMinusTwoNewListsReturnsValueAtIndex0()  //Overloading - Operator
        {
            //Arrange

            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            //Act
            customList1.Add(3);
            customList1.Add(5);
            customList1.Add(7);
            customList1.Add(1);
            customList1.Add(6);
            customList2.Add(4);
            customList2.Add(5);
            customList2.Add(1);
            customList2.Add(8);
            customList2.Add(2);

            CustomList<int> overLoadMinus = customList1 - customList2; // result 3 7 6

            //Assert
            Assert.AreEqual(3, overLoadMinus[0]);
        }

        [TestMethod]
        public void OverLoadMinusTwoNewListsReturnsValueAtIndex1()  //Overloading - Operator
        {
            //Arrange

            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            //Act
            customList1.Add(3);
            customList1.Add(5);
            customList1.Add(7);
            customList1.Add(1);
            customList1.Add(6);
            customList2.Add(4);
            customList2.Add(5);
            customList2.Add(1);
            customList2.Add(8);
            customList2.Add(2);

            CustomList<int> overLoadMinus = customList1 - customList2; // result 3 7 6

            //Assert
            Assert.AreEqual(7, overLoadMinus[1]);
        }

        [TestMethod]
        public void OverLoadMinusTwoNewListsReturnsValueAtIndex2()  //Overloading - Operator
        {
            //Arrange

            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            //Act
            customList1.Add(3);
            customList1.Add(5);
            customList1.Add(7);
            customList1.Add(1);
            customList1.Add(6);
            customList2.Add(4);
            customList2.Add(5);
            customList2.Add(1);
            customList2.Add(8);
            customList2.Add(2);

            CustomList<int> overLoadMinus = customList1 - customList2; // result 3 7 6

            //Assert
            Assert.AreEqual(6, overLoadMinus[2]);
        }

        [TestMethod]
        public void SortIntReturnsValueAtIndex5()  //Sorting integers.
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            
            //Act
            customList.Add(8);
            customList.Add(4);
            customList.Add(1);
            customList.Add(5);
            customList.Add(3);
            customList.Add(7);
            customList.SortAscending();  //Result 1 3 4 5 7 8

            //Assert
            Assert.AreEqual(8, customList[5]);
        }

        [TestMethod]
        public void SortIntReturnsValueAtIndex4()  //Sorting integers.
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(8);
            customList.Add(4);
            customList.Add(1);
            customList.Add(5);
            customList.Add(3);
            customList.Add(7);
            customList.SortAscending(); //Result 1 3 4 5 7 8

            //Assert
            Assert.AreEqual(7, customList[4]);
        }

        [TestMethod]
        public void SortCharReturnsValueAtIndex1() //Sorting character.
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add("c");
            customList.Add("h");
            customList.Add("d");
            customList.Add("m");
            customList.Add("b");
            customList.Add("f");
            customList.SortAscending();  //Result b c d f h m

            //Assert
            Assert.AreEqual("c", customList[1]);
        }

        [TestMethod]
        public void SortCharReturnsValueAtIndex3() //Sorting character.
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add("c");
            customList.Add("h");
            customList.Add("d");
            customList.Add("m");
            customList.Add("b");
            customList.Add("f");
            customList.SortAscending();  //Result b c d f h m

            //Assert
            Assert.AreEqual("f", customList[3]);
        }

        [TestMethod]    //sorting 'full' string.
        public void SortStringReturnsValueAtIndex4()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add("five");
            customList.Add("nine");
            customList.Add("one");
            customList.Add("eight");
            customList.Add("zero");
            customList.Add("two");
            customList.SortAscending();  
            //Result "eight" "five" "nine" "one" "two" "zero"

            //Assert
            Assert.AreEqual("two", customList[4]);           
        }

        [TestMethod]
        public void ToStringIntListReturnsString1()  
            //ToString Override, string output expected for int list.
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(8);
            customList.Add(4);
            customList.Add(1);
            customList.Add(5);
            customList.Add(3);
            customList.Add(7);
            string customString = customList.ToString();

            //Assert
            Assert.AreEqual("8.4.1.5.3.7", customString);
        }

        [TestMethod]
        public void ToStringIntListReturnsString2()  
            //ToString Override, string output expected for int list.
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(5);
            customList.Add(4);
            customList.Add(6);
            customList.Add(9);
            customList.Add(2);
            customList.Add(7);
            string customString = customList.ToString();

            //Assert
            Assert.AreEqual("5.4.6.9.2.7", customString);
        }

        [TestMethod]
        public void ToStringStringListReturnsString1()  
            //ToString Override, string output expected for string list.
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add("five");
            customList.Add("nine");
            customList.Add("one");
            customList.Add("eight");
            customList.Add("zero");
            customList.Add("two");
            string customString = customList.ToString();
            
            //Assert
            Assert.AreEqual("five.nine.one.eight.zero.two", customString);
        }

        [TestMethod]
        public void ToStringStringListReturnsString2()
        //ToString Override, string output expected for string list.
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add("five");
            customList.Add("nine");
            customList.Add("1");
            customList.Add("eight");
            customList.Add("zero");
            customList.Add("two");
            string customString = customList.ToString();

            //Assert
            Assert.AreEqual("five.nine.1.eight.zero.two", customString);
        }

        [TestMethod]
        public void ToStringStringListReturnsString3()
        //ToString Override, string output expected for string list.
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();

            //Act
            customList.Add("five");
            customList.Add("nine");
            customList.Add("1");
            customList.Add(" ");
            customList.Add("zero");
            customList.Add("two");
            string customString = customList.ToString();

            //Assert
            Assert.AreEqual("five.nine.1. .zero.two", customString);
        }

        [TestMethod]
        public void ForEachIntReturnSum() 
            //Foreach loop adds int elements from indices 0 to count-1
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int sum = 0;

            //Act
            customList.Add(0);
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            foreach (int number in customList)
            {
                sum += number;
            }
            //Assert
            Assert.AreEqual(10, sum);
        }

        [TestMethod]
        public void ForEachIntReturnSum2() 
            //Foreach loop adds int elements from indices 0 to count-1
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int sum = 0;

            //Act
            customList.Add(0);
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            foreach (int number in customList)
            {
                sum += number;
            }
            //Assert
            Assert.AreEqual(15, sum);
        }

        [TestMethod]
        public void ForEachIntReturnSum3() 
            //Foreach loop adds int elements from indices 0 to count-1
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int sum = 0;

            //Act
            customList.Add(0);
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(2);
            foreach (int number in customList)
            {
                sum += number;
            }
            //Assert
            Assert.AreEqual(17, sum);
        }

        [TestMethod]
        public void ForEachIntReturnSum4() 
            //Foreach loop adds int elements from indices 0 to count-1
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int sum = 0;

            //Act
            customList.Add(5);
            customList.Add(1);
            customList.Add(6);
            customList.Add(4);
            customList.Add(2);
            foreach (int number in customList)
            {
                sum += number;
            }
            //Assert
            Assert.AreEqual(18, sum);
        }

        [TestMethod]
        public void ForEachIntReturnSum5() 
            //Foreach loop adds int elements from indices 0 to count-1
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int sum = 0;

            //Act
            customList.Add(5);
            customList.Add(100);
            customList.Add(6);
            customList.Add(4);
            customList.Add(2);
            foreach (int number in customList)
            {
                sum += number;
            }
            //Assert
            Assert.AreEqual(117, sum);
        }

    }
}

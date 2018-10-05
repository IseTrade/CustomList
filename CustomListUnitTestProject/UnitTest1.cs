using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
namespace CustomListUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod01()   //Testing to see if value passed to customList.Add is the same as value 
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
        public void TestMethod02()  //Testing to see if an actual integer is passed and stored correctly. 
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            //int value = 16;

            //Act
            customList.Add(16);

            //Assert

            Assert.AreEqual(16, customList[0]);
        }

        [TestMethod]
        public void TestMethod03()  //Test passing a negative int.
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(-16);

            //Assert

            Assert.AreEqual(-16, customList[0]);
        }

        [TestMethod]
        public void TestMethod04()  //Test passing a string
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
        public void TestMethod05()  //Test passing null
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string value = "";

            //Act
            customList.Add(value);

            //Assert

            Assert.AreEqual(value, customList[0]);
        }


        [TestMethod]
        public void TestMethod06()    //Testing to see if index works on [1]
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 20;

            //Act
            customList.Add(value);
            customList.Add(value1);

            //Assert
            Assert.AreEqual(value1, customList[1]);
        }


        [TestMethod]
        public void TestMethod07()    //Count test before doubling Array [4]
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
        public void TestMethod08()    //Testing to see if index works on [1]
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>(); //Count test at 1st doubling Array[8]

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
        public void TestMethod09()    //Testing to see if index works on [1]
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();   //Count test at 2nd doubling Array[16]

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
        public void TestMethod10()    // Count test at 3rd doubling or array[32]
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
        public void TestMethod11()    
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
            customList.Add(5);
            customList.Add(6);
            customList.Remove(4);
            //Assert
            Assert.AreEqual(5, customList[4]);
        }


    }
}

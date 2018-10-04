using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
namespace CustomListUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()   //Testing to see if value passed to customList.Add is the same as value 
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
        public void TestMethod2()  //Testing to see if an actual integer is passed and stored correctly. 
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
        public void TestMethod3()  //Test passing a negative int.
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(-16);

            //Assert

            Assert.AreEqual(-16, customList[0]);
        }

        [TestMethod]
        public void TestMethod4()  //Test passing a string
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
        public void TestMethod5()  //Test passing null
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string value = "";

            //Act
            customList.Add(value);

            //Assert

            Assert.AreEqual(value, customList[0]);
        }


        //[TestMethod]
        //public void TestMethod2()
        //{
        //    //Arrange
        //    CustomList<int> customList = new CustomList<int>();
        //    int value = 16;
        //    int countValue = 1;

        //    //Act
        //    customList.Add(value);

        //    //Assert
        //    Assert.AreEqual(customList.Count, countValue);
        //}
        [TestMethod]
        public void TestMethod6()    //Testing to see if index works on [1]
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 20;

            //Act
            customList.Add(value);
            //customList.Add(value1);

            //Assert
            Assert.AreEqual(value, customList[1]);
        }

        [TestMethod]
        public void TestMethod7()    //Testing to see if index works on [1]
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 20;

            //Act
            customList.Add(value);
            //customList.Add(value1);

            //Assert
            Assert.AreEqual(value, customList[1]);
        }

        [TestMethod]
        public void TestMethod8()    //Testing to see if index works on [1]
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value = 16;
            int value1 = 20;

            //Act
            customList.Add(16);
            customList.Add(17);
            customList.Add(18);

            //Assert
            Assert.AreEqual(18, customList[2]);
        }
    }
}

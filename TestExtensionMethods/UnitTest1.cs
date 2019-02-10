using System;
using System.Collections.Generic;
using CustomLinq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestExtensionMethods
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFilter2()
        {
            CustomList<int> list = new CustomList < int >();
            list.add(1);list.add(5);list.add(15);list.add(26);

            var whereResult = list.Filter(x => x > 5);
            int count = 0;
            foreach (var element in whereResult)
            {
                count++;
            }
            Assert.AreEqual(2,count);
        }

        [TestMethod]
        public void TestMapTrue()
        {
            IIteratable<int> list = new CustomList<int>();
            list.add(1); list.add(5); list.add(15); list.add(26);
            
            
            var mapResult = list.Map(x => x *2);
            var expectedList = new List<int>() { 2, 10, 30, 52 };
            int counter = 0;
            bool isMapCorrect=true;
            foreach (var element in mapResult)
            {
                if (element != expectedList[counter])
                {
                    isMapCorrect = false;
                    break;
                }

                counter++;
            }
            Assert.AreEqual(true,isMapCorrect);
        }
        [TestMethod]
        public void TestMapFalse()
        {
            IIteratable<int> list = new CustomList<int>();
            list.add(1); list.add(5); list.add(15); list.add(26);


            var mapResult = list.Map(x => x * 2);
            var expectedList = new List<int>() { 2, 10, 55, 52 };
            int counter = 0;
            bool isMapCorrect = true;
            foreach (var element in mapResult)
            {
                if (element != expectedList[counter])
                {
                    isMapCorrect = false;
                    break;
                }

                counter++;
            }
            Assert.AreEqual(false, isMapCorrect);
        }
        [TestMethod]
        public void TestAllTrue()
        {
            CustomList<int> list = new CustomList<int>();
            list.add(1); list.add(5); list.add(15); list.add(26);

            var mapResult = list.All(x => x >0);
        
            Assert.AreEqual(true, mapResult);
        }
        [TestMethod]
        public void TestAllFalse()
        {
            CustomList<int> list = new CustomList<int>();
            list.add(1); list.add(5); list.add(15); list.add(34);

            var mapResult = list.All(x => x > 30);

            Assert.AreEqual(false, mapResult);
        }

        [TestMethod]
        public void TestSomeTrue()
        {
            CustomList<int> list = new CustomList<int>();
            list.add(1); list.add(5); list.add(15); list.add(26);

            var mapResult = list.Some(x => x > 21);

            Assert.AreEqual(true, mapResult);
        }
        [TestMethod]
        public void TestMapFilter()
        {
            IIteratable<int> list = new CustomList<int>();
            list.add(1); list.add(5); list.add(15); list.add(26);list.add(-33);


            var Result = list.Map(x => x +4).Filter(x=>x>10);
            var expectedList = new List<int>() { 19,30};
            int counter = 0;
            bool isMapCorrect = true;
            foreach (var element in Result)
            {
                if (element != expectedList[counter])
                {
                    isMapCorrect = false;
                    break;
                }

                counter++;
            }
            Assert.AreEqual(true, isMapCorrect);
        }

    }
}

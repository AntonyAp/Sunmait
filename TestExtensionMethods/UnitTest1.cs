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
            var list = new CustomList < int >(1,5,15,26);
            int count = 0;

            var whereResult = list.Filter(x => x > 5);
            foreach (var element in whereResult)
            {
                count++;
            }

            Assert.AreEqual(2,count);
        }
        [TestMethod]
        public void TestFilterDeferredExecution()
        {
            var list = new CustomList<int>(1, 5, 15, 26);
            int count = 0;
            bool checkFilterResult = true;

            var whereResult = list.Filter(x => x > 5);
            list.Add(55);
            foreach (var element in whereResult)
            {
                if (element <=5)
                {
                    checkFilterResult = false;
                    break;
                }
                count++;
            }

            if (count != 3) checkFilterResult = false;
            Assert.AreEqual(true, checkFilterResult);
        }
        [TestMethod]
        public void TestFilterValues()
        {
            var list = new CustomList<int>(1, 5, 15, 26,33);
            int count = 0;
            bool checkFilterResult = true;

            var whereResult = list.Filter(x => x %2!=0);
            foreach (var element in whereResult)
            {
                if (element % 2 == 0)
                {
                    checkFilterResult = false;
                    break;
                }
                count++;
            }
            if (count != 4) checkFilterResult = false;

            Assert.AreEqual(true, checkFilterResult);
        }
        [TestMethod]
        public void TestMapTrue()
        {
            var list = new CustomList<int>(1,5,15,26);
            int counter = 0;
            bool isMapCorrect = true;

            var mapResult = list.Map(x => x *2);
            var expectedList = new List<int>() { 2, 10, 30, 52 };
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
        public void TestMapDeferredExecution()
        {
            var list = new CustomList<int>(1, 5, 15, 26);
            int counter = 0;
            bool isMapCorrect = true;

            var mapResult = list.Map(x => x * 2);
            list.Add(11);
            var expectedList = new List<int>() { 2, 10, 30, 52,22 };
            foreach (var element in mapResult)
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
        [TestMethod]
        public void TestMapFalse()
        {
            var list = new CustomList<int>(1,5,15,26);
            int counter = 0;
            bool isMapCorrect = true;

            var mapResult = list.Map(x => x * 2);
            var expectedList = new List<int>() { 2, 10, 55, 52 };
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
            var list = new CustomList<int>(1,5,15,26);

            var mapResult = list.All(x => x >0);
        
            Assert.AreEqual(true, mapResult);
        }
        [TestMethod]
        public void TestAllFalse()
        {
            var list = new CustomList<int>(1,5,15,34);
     
            var mapResult = list.All(x => x > 30);

            Assert.AreEqual(false, mapResult);
        }
        [TestMethod]
        public void TestSomeTrue()
        {
            var list = new CustomList<int>(1,5,15,26);
            
            var mapResult = list.Some(x => x > 21);

            Assert.AreEqual(true, mapResult);
        }
        [TestMethod]
        public void TestMapFilter()
        {
            var list = new CustomList<int>(1,5,15,26,-33);
            int counter = 0;
            bool isMapCorrect = true;

            var Result = list.Map(x => x +4).Filter(x=>x>10);
            var expectedList = new List<int>() { 19,30};
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

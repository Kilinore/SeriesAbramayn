using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MySeriesTasks.Tests
{
    [TestClass]
    public class MySeriesTests
    {
        [TestMethod]
        public void Test1Series16_3andArray123450_5Expected()
        {
            // arrange
            int k = 3;
            int[] arr = new int[6] { 1, 2, 3, 4, 5, 0 };
            int expected = 5;

            // act
            MyTasks t = new MyTasks();
            int actual = t.Series16(k, arr);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2Series16_7andArray123450_0Expected()
        {
            // arrange
            int k = 7;
            int[] arr = new int[6] { 1, 2, 3, 4, 5, 0 };
            int expected = 0;

            // act
            MyTasks t = new MyTasks();
            int actual = t.Series16(k, arr);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test1Series22_5andArray54321_0Expected()
        {
            // arrange
            int n = 5;
            double[] arr = new double[5] {5,4,3,2,1};
            int expected = 0;

            // act
            MyTasks t = new MyTasks();
            int actual = t.Series22(n, arr);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2Series22_5andArray56321_2Expected()
        {
            // arrange
            int n = 5;
            double[] arr = new double[5] { 5, 6, 3, 2, 1 };
            int expected = 2;

            // act
            MyTasks t = new MyTasks();
            int actual = t.Series22(n, arr);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test1Series24_5andArray00050_5Expected()
        {
            // arrange
            int n = 5;
            int[] arr = new int[5] { 0, 0, 0, 5, 0 };
            int expected = 5;

            // act
            MyTasks t = new MyTasks();
            int actual = t.Series24(n, arr);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2Series24_5andArray05000_0Expected()
        {
            // arrange
            int n = 5;
            int[] arr = new int[5] { 0, 5, 0, 0, 0 };
            int expected = 0;

            // act
            MyTasks t = new MyTasks();
            int actual = t.Series24(n, arr);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task1.MainWindow;

namespace Task1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        /// <summary>
        /// Метод Евклида для вычисления НОД двух целых чисел
        /// </summary>
        public void Euclidean_1071And462_Returned_21()
        {
            //arrange
            long a = 1071;
            long b = 462;
            long expected = 21;
            TimeSpan time;

            //assert
            Assert.AreEqual(expected, GCD.Euclidean(out time, a, b));
        }

        [TestMethod]
        /// <summary>
        /// Метод Евклида для вычисления НОД трех целых чисел
        /// </summary>
        public void Euclidean_1071_462_And7_Returned_7()
        {
            //arrange
            long a = 1071;
            long b = 462;
            long c = 7;
            long expected = 7;
            TimeSpan time;

            //assert
            Assert.AreEqual(expected, GCD.Euclidean(out time, a, b, c));
        }

        [TestMethod]
        /// <summary>
        /// Метод Евклида для вычисления НОД четырех целых чисел
        /// </summary>
        public void Euclidean_15_55_5_25_Returned_5()
        {
            //arrange
            long a = 15;
            long b = 55;
            long c = 5;
            long d = 25;
            long expected = 5;
            TimeSpan time;

            //assert
            Assert.AreEqual(expected, GCD.Euclidean(out time, a, b, c, d));
        }

        [TestMethod]
        /// <summary>
        /// Метод Евклида для вычисления НОД пяти целых чисел
        /// </summary>
        public void Euclidean_26_2_224_12_7_Returned_1()
        {
            //arrange
            long a = 26;
            long b = 2;
            long c = 224;
            long d = 12;
            long e = 7;
            long expected = 1;
            TimeSpan time;

            //assert
            Assert.AreEqual(expected, GCD.Euclidean(out time, a, b, c, d, e));
        }

        [TestMethod]
        /// <summary>
        /// Метод Евклида(бинарный) для вычисления НОД двух целых чисел
        /// </summary>
        public void BinaryEuclidean_1071And462_Returned_21()
        {
            //arrange
            long a = 1071;
            long b = 21;
            long expected = 21;
            TimeSpan time;

            //assert
            Assert.AreEqual(expected, GCD.BinaryEuclidean(out time, a, b));
        }

    }
}

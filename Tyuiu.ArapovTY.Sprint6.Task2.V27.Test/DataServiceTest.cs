﻿using Tyuiu.ArapovTY.Sprint6.Task2.V27.Lib;
namespace Tyuiu.ArapovTY.Sprint6.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray[0] = -27.22;
            valueWaitArray[1] = -22.25;
            valueWaitArray[2] = -16.66;
            valueWaitArray[3] = -11.04;
            valueWaitArray[4] = -6.13;
            valueWaitArray[5] = -3;
            valueWaitArray[6] = 4.84;
            valueWaitArray[7] = 8.86;
            valueWaitArray[8] = 14.43;
            valueWaitArray[9] = 20.18;
            valueWaitArray[10] = 25.24;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}

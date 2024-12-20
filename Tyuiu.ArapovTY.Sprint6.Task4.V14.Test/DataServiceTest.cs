﻿using Tyuiu.ArapovTY.Sprint6.Task4.V14.Lib;
namespace Tyuiu.ArapovTY.Sprint6.Task4.V14.Test
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
            valueWaitArray[0] = -19.62;
            valueWaitArray[1] = -17.12;
            valueWaitArray[2] = -18.15;
            valueWaitArray[3] = -63.13;
            valueWaitArray[4] = -24.92;
            valueWaitArray[5] = -5;
            valueWaitArray[6] = -1.46;
            valueWaitArray[7] = 1.57;
            valueWaitArray[8] = 6.38;
            valueWaitArray[9] = 32.78;
            valueWaitArray[10] = 225.11;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}

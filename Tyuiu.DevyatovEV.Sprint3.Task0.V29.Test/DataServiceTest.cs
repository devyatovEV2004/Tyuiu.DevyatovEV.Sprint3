using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevyatovEV.Sprint3.Task0.V29.Lib;

namespace Tyuiu.DevyatovEV.Sprint3.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double t = 0.5;
            int startValue = 1;
            int stopValue = 10;

            double result = ds.GetSumSeries(t, startValue, stopValue);

            // Правильный расчет ожидаемого значения
            double expected = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                expected += (Math.Pow(t, 2 * k) + (1.0 / (k + 1))) * Math.Cos(t);
            }
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result);
        }
    }
}
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

            double result = ds.GetSumSeries(t);

            // Правильный расчет ожидаемого значения
            double expected = 0;
            for (int k = 1; k <= 10; k++)
            {
                expected += (Math.Pow(t, 2 * k) + (1.0 / (k + 1))) * Math.Cos(t);
            }
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result);
        }
    }
}
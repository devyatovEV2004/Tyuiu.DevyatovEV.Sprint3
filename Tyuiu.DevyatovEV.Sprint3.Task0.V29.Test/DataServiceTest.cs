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
            double wait = 3.918; // Ожидаемое значение при t=0.5

            Assert.AreEqual(wait, result);
        }
    }
}
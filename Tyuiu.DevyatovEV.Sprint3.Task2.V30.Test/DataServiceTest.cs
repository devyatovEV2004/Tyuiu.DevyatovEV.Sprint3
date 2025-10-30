using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint3.Task2.V30.Lib;

namespace Tyuiu.DevyatovEV.Sprint3.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double x = 0.25;
            int startValue = 1;
            int stopValue = 11;

            double result = ds.GetMultiplySeries(x, startValue, stopValue);

            double wait = 3.0625 * 4.0625 * 5.0625 * 6.0625 * 7.0625 * 8.0625 * 9.0625 * 10.0625 * 11.0625 * 12.0625 * 13.0625;
            wait = Math.Round(wait, 3);

            Assert.AreEqual(wait, result);
        }
    }
}
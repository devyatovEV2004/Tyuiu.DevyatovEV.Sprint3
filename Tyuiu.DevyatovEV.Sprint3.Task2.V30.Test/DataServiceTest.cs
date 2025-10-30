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

            // Автоматический расчет ожидаемого значения
            double expected = 1;
            int i = startValue;
            do
            {
                expected *= (Math.Pow(x, 2) + i) + 2;
                i++;
            }
            while (i <= stopValue);
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result);
        }
    }
}
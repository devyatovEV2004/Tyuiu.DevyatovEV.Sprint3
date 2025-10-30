using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint3.Task4.V29.Lib;

namespace Tyuiu.DevyatovEV.Sprint3.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double result = ds.Calculate(startValue, stopValue);

            double expected = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) continue;
                expected += Math.Cos(x) / x;
            }
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result);
        }
    }
}
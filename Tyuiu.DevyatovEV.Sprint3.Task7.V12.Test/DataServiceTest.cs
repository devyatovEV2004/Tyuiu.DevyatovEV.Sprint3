using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint3.Task7.V12.Lib;

namespace Tyuiu.DevyatovEV.Sprint3.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] result = ds.GetMassFunction(startValue, stopValue);

            double[] wait = {
                CalculateFunction(-5),  // x = -5
                CalculateFunction(-4),  // x = -4  
                CalculateFunction(-3),  // x = -3
                CalculateFunction(-2),  // x = -2
                CalculateFunction(-1),  // x = -1
                CalculateFunction(0),   // x = 0
                CalculateFunction(1),   // x = 1
                CalculateFunction(2),   // x = 2
                CalculateFunction(3),   // x = 3
                CalculateFunction(4),   // x = 4
                CalculateFunction(5)    // x = 5
            };

            CollectionAssert.AreEqual(wait, result);
        }

        private double CalculateFunction(int x)
        {
            if (3 * x + 0.5 == 0)
                return 0;

            return Math.Round(Math.Sin(x) + (2.0 / (3 * x + 0.5)) - 2 * Math.Cos(x) * 2 * x, 2);
        }
    }
}
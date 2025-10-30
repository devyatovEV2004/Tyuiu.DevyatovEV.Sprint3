using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint3.Task6.V7.Lib;

namespace Tyuiu.DevyatovEV.Sprint3.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 17;
            int stopValue = 26;

            int result = ds.GetSumTheDivisors(startValue, stopValue);

            // 17: 1 + 17 = 18
            // 18: 1 + 2 + 3 + 6 + 9 + 18 = 39
            // 19: 1 + 19 = 20
            // 20: 1 + 2 + 4 + 5 + 10 + 20 = 42
            // 21: 1 + 3 + 7 + 21 = 32
            // 22: 1 + 2 + 11 + 22 = 36
            // 23: 1 + 23 = 24
            // 24: 1 + 2 + 3 + 4 + 6 + 8 + 12 + 24 = 60
            // 25: 1 + 5 + 25 = 31
            // 26: 1 + 2 + 13 + 26 = 42
            // Итого: 18 + 39 + 20 + 42 + 32 + 36 + 24 + 60 + 31 + 42 = 344
            int wait = 344;

            Assert.AreEqual(wait, result);
        }
    }
}
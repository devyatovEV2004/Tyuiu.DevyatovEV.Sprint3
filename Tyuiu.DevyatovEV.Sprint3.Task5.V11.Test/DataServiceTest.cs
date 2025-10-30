using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint3.Task5.V11.Lib;

namespace Tyuiu.DevyatovEV.Sprint3.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(79.234, ds.GetSumSumSeries(5, 1, 1, 3, 10));

        }
    }
}
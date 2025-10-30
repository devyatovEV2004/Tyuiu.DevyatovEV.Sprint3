using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.DevyatovEV.Sprint3.Task3.V20.Lib;

namespace Tyuiu.DevyatovEV.Sprint3.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string str = "gift ntf f opf";
            char letter = 'f';

            int result = ds.GetCharCount(str, letter);

            // В строке "gift ntf f opf" буквы 'f' находятся на позициях:
            // gift - 3-я позиция
            // ntf - 3-я позиция  
            // f - 1-я позиция
            // opf - 3-я позиция
            // Итого: 4 буквы 'f'
            int wait = 4;

            Assert.AreEqual(wait, result);
        }
    }
}
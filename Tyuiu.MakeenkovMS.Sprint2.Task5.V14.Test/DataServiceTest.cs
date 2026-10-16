using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MakeenkovMS.Sprint2.Task5.V14.Lib;

namespace Tyuiu.MakeenkovMS.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 2;
            int d = 1;
            string wait = "Вторник";
            string res = ds.FindDayName(k, d);
            Assert.AreEqual(wait, res);
        }
    }
}


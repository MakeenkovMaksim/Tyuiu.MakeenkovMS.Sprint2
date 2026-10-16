using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MakeenkovMS.Sprint2.Task6.V9.Lib;

namespace Tyuiu.MakeenkovMS.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int n = 8;
            int m = 9;
            string wait = "10.08";
            string res = ds.FindDateOfNextDay(n, m);
            Assert.AreEqual(wait, res);
        }
    }
}


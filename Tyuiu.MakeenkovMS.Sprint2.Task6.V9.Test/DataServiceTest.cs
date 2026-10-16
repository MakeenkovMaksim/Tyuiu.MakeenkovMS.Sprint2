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
            int m = 9;
            int n = 9;
            string wait = "10.09";
            string res = ds.FindDateOfNextDay(n, m);
            Assert.AreEqual(wait, res);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MakeenkovMS.Sprint2.Task3.V9.Lib;

namespace Tyuiu.MakeenkovMS.Sprint2.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 1;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}

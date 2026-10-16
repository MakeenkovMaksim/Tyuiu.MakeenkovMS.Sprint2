using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MakeenkovMS.Sprint2.Task4.V6.Lib;

namespace Tyuiu.MakeenkovMS.Sprint2.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 0.667;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}

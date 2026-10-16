using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MakeenkovMS.Sprint2.Task1.V7.Lib;

namespace Tyuiu.MakeenkovMS.Sprint2.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 195;
            int b = 16;
            int c = 14;
            int d = 45;
            bool[] wait = { true, false, false, false, true, false };

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}

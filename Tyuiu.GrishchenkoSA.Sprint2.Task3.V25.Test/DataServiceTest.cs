using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint2.Task3.V25.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint2.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(2.0);
            Assert.AreEqual(9.989, res, 0.001);
        }
    }
}

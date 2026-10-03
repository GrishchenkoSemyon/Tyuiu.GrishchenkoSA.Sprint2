using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint2.Task4.V13.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint2.Task4.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(10.0, 10.0);
            Assert.AreEqual(109.9, res, 0.001);
        }
    }
}

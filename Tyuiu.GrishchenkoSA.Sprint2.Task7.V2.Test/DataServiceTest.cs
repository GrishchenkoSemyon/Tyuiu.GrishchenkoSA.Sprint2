using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint2.Task7.V2.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint2.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.CheckDotInShadedArea(0.5, -0.2);
            Assert.AreEqual(true, res);
        }
    }
}

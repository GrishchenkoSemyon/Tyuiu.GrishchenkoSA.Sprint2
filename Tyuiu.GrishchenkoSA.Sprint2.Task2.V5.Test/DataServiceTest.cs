using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint2.Task2.V5.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint2.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.CheckDotInShadedArea(3, 4);
            Assert.AreEqual(true, res);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint2.Task6.V1.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint2.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.FindMonthDaysCount(2);
            Assert.AreEqual(28, res);
        }
    }
}

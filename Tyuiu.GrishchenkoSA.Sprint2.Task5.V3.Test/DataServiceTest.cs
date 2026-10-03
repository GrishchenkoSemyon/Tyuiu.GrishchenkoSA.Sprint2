using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint2.Task5.V3.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint2.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.FindDayName(1);
            Assert.AreEqual("понедельник", res);
        }
    }
}

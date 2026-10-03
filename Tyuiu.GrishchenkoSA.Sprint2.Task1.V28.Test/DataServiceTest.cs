using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GrishchenkoSA.Sprint2.Task1.V28.Lib;

namespace Tyuiu.GrishchenkoSA.Sprint2.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.GetLogicOperations(247, 654, 671, 671);
            CollectionAssert.AreEqual(new bool[] { true, false, true, false, true, false }, res);
        }
    }
}

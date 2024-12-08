using Tyuiu.ArapovTY.Sprint6.Task0.V15.Lib;
namespace Tyuiu.ArapovTY.Sprint6.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 63;
            Assert.AreEqual(wait, res);
        }
    }
}
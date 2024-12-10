using Tyuiu.ArapovTY.Sprint6.Task6.V20.Lib;
namespace Tyuiu.ArapovTY.Sprint6.Task6.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint6\InPutDataFileTask6V20.txt";
            string[] res = ds.CollectTextFromFile(path);
            string[] wait = new string[] { "dKOPBC", "IqjpIlKAaSCBuaQUU", "GPeEqZo", "FPsrQHsImzbTBckw", "NgAfitECn" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}

using Tyuiu.ArapovTY.Sprint6.Task7.V21.Lib;
namespace Tyuiu.ArapovTY.Sprint6.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint6\InPutDataFileTask7V21.csv";
            int[,] res = ds.GetMatrix(path);
            int[,] wait = new int[,] { { -4, -2, 13, -12, 12, -19, 5, -6, -1, -12 },
                                       { 19, 2, -3, 1, -9, -10, 6, 14, -1, -5 },
                                       { -14, 13, 2, 8, -12, 3, -5, -13, -1, -4 },
                                       { -6, -13, 3, 19, -10, 9, 2, 13, -1, 16 },
                                       { -14, -12, 1, 5, 14, 3, -7, 7, -1, -12 },
                                       { -13, -1, -1, 14, 11, -1, 4, -18, -1, -4 },
                                       { -11, 7, 2, 3, -12, -19, -12, 11, -1, 5 },
                                       { 4, 20, -4, -10, 8, -16, -14, -6, -1, 6 },
                                       { -19, -5, -9, -19, 2, -2, 7, -7, -1, 14 },
                                       { -4, 13, 4, 8, -19, -18, 19, -5, -1, -12 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}

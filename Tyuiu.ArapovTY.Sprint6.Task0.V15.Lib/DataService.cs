using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ArapovTY.Sprint6.Task0.V15.Lib
{
    public class DataService : ISprint6Task0V15
    {
        public double Calculate(int x)
        {
            double y = Convert.ToDouble(x);
            double res = Math.Pow(y, 3) + 2 * Math.Pow(y, 2) + 5 * y + 4;
            return Math.Round(res, 3);
        }
    }
}

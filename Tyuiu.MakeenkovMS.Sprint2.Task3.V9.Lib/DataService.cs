using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MakeenkovMS.Sprint2.Task3.V9.Lib
{
    public class DataService : ISprint2Task3V9
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0)
            {
                y = x * Math.Pow((x + 15) / (x - 7), x);
            }
            else if (x == 0)
            {
                y = (Math.Sin(x) + Math.Cos(x)) / (Math.Cos(x) - Math.Sin(x));
            }
            else if (x > -13 && x < 0)
            {
                y = Math.Pow(1 + 4 / (x * x), x);
            }
            else if (x < -13)
            {
                y = x + 10 * x + Math.Pow(1 / x, 2);
            }

            return Math.Round(y, 3);
        }
    }
}

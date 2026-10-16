using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MakeenkovMS.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int n, int m)
        {
            int daysInMonth = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28,
                _ => 0
            };

            if (n < daysInMonth)
            {
                n++;
            }
            else
            {
                n = 1;
                if (m == 12)
                {
                    m = 1;
                }
                else
                {
                    m++;
                }
            }

            string dayStr = n < 10 ? "0" + n : n.ToString();
            string monthStr = m < 10 ? "0" + m : m.ToString();

            return dayStr + "." + monthStr;
        }
    }
}
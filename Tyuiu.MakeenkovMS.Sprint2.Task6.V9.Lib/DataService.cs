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

            int nextDay = (n < daysInMonth) ? (n + 1) : 1;
            int nextMonth = (n < daysInMonth) ? m : (m == 12 ? 1 : m + 1);

            string dayStr = nextDay < 10 ? "0" + nextDay : nextDay.ToString();
            string monthStr = nextMonth < 10 ? "0" + nextMonth : nextMonth.ToString();

            return dayStr + "." + monthStr;
        }
    }
}

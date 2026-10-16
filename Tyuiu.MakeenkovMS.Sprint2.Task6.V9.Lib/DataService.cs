using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MakeenkovMS.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int n, int m)
        {
            int day = m;
            int month = n;

            int daysInMonth = month switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 => 30,
                2 => 28,
                _ => 0
            };

            int nextDay = (day < daysInMonth) ? (day + 1) : 1;
            int nextMonth = (day < daysInMonth) ? month : (month == 12 ? 1 : month + 1);

            string dayStr = nextDay < 10 ? "0" + nextDay : nextDay.ToString();
            string monthStr = nextMonth < 10 ? "0" + nextMonth : nextMonth.ToString();

            return dayStr + "." + monthStr;
        }
    }
}

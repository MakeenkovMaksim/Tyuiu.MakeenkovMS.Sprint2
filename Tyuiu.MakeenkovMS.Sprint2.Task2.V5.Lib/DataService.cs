using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MakeenkovMS.Sprint2.Task2.V5.Lib
{
    public class DataService : ISprint2Task2V5
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 3 && x <= 5 && y >= 3 && y <= 4) ||
                (x >= 9 && x <= 12 && y >= 3 && y <= 4) ||
                (x >= 3 && x <= 12 && y >= 5 && y <= 6) ||
                (x >= 6 && x <= 12 && y >= 7 && y <= 8) ||
                (x >= 6 && x <= 9 && y >= 9 && y <= 10) ||
                (x >= 3 && x <= 9 && y == 11) ||
                (x >= 7 && x <= 11 && y == 12))
            {
                return true;
            }
            return false;
        }
    }
}

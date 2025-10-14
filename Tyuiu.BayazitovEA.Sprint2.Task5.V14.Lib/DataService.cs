using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BayazitovEA.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {

            int dayOfWeek = (d - 1 + k - 1) % 7 + 1;

            switch (dayOfWeek)
            {
                case 1: return "понедельник";
                case 2: return "вторник";
                case 3: return "среда";
                case 4: return "четверг";
                case 5: return "Пятница";
                case 6: return "суббота";
                case 7: return "воскресенье";
                default: return "ошибка";
            }
        }

        public static int CalculateDayOfWeekNumber(int k, int d)
        {
            return (d - 1 + k - 1) % 7 + 1;
        }
    }
}

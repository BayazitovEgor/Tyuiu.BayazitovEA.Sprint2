using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BayazitovEA.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            if (k < 1 || k > 365) return "error";

            int dayOfWeek = (k - 1) % 7;

            return dayOfWeek switch
            {
                0 => "понедельник",
                1 => "вторник",
                2 => "среда",
                3 => "четверг",
                4 => "пятница",
                5 => "Суббота",
                6 => "воскресенье",
                _ => "error"
            };
    }
    } }

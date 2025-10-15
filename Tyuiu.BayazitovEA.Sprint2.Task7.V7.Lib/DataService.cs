using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BayazitovEA.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return (y <= 2 - x * x) && (y >= x);
        }
    }
}

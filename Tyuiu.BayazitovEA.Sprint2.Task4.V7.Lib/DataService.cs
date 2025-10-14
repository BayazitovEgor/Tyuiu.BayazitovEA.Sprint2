using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BayazitovEA.Sprint2.Task4.V7.Lib
{
    public class DataService : ISprint2Task4V7
    {
        public double Calculate(double x, double y)
        {
            double z = 0;


            if (x - 10 > y + 2)
            {
                z = Math.Pow(1 + Math.Sqrt(x + 3) / Math.Pow(x, 2), y);
            }
            else
            {
                z = Math.Pow(x, 3) + 2 * x + (6 + 4 / (Math.Pow(y, 2)));
            }
            return Math.Round(z, 3);
        }
    }
    }


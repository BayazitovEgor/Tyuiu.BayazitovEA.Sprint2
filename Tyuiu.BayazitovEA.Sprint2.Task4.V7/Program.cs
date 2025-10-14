using Tyuiu.BayazitovEA.Sprint2.Task4.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        double res = ds.Calculate(x, y);
        Console.WriteLine(res);
    }
}
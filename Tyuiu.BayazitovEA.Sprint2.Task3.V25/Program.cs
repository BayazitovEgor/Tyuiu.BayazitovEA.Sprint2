using Tyuiu.BayazitovEA.Sprint2.Task3.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        double x = Convert.ToDouble(Console.ReadLine());
        double res = ds.Calculate(x);
        Console.WriteLine(res);
    }
}
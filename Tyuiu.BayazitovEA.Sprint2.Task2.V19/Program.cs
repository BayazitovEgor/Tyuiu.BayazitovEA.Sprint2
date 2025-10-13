using Tyuiu.BayazitovEA.Sprint2.Task2.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        DataService ds = new DataService();
        bool res = ds.CheckDotInShadedArea(x, y);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}
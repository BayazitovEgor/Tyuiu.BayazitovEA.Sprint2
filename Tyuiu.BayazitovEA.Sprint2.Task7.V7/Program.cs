using Tyuiu.BayazitovEA.Sprint2.Task7.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        bool res = ds.CheckDotInShadedArea(x,y);
        Console.WriteLine(res);
    }
}
using Tyuiu.BayazitovEA.Sprint2.Task5.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int k = 12;
        int d = 3;
        string res = ds.FindDayName(k, d);
        Console.WriteLine(res);
    }
}
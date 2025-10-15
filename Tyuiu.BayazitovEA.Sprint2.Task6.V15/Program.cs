using Tyuiu.BayazitovEA.Sprint2.Task6.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int k = 12;

        string res = ds.FindDayName(k);
        Console.WriteLine(res);
    }
}
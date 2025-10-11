using Tyuiu.BayazitovEA.Sprint2.Task0.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 105;
        int y = 795;
        bool[]res = new bool[6];
        res=ds.GetCompareOperations(x, y);
        for (int i = 0; i < 6; i++)
        { Console.Write(res[i]); }
        Console.ReadKey();
    }
}
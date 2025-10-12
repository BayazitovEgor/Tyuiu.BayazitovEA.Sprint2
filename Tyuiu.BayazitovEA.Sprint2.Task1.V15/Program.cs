using Tyuiu.BayazitovEA.Sprint2.Task1.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int a = 415;
        int b = 616;
        int c = 134;
        int d = 127;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a,b,c,d);
        for (int i = 0; i < 6; i++)
        { Console.Write(res[i]); }
        Console.ReadKey();
    }
}
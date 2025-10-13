using Tyuiu.BayazitovEA.Sprint2.Task3.V25.Lib;
namespace Tyuiu.BayazitovEA.Sprint2.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}

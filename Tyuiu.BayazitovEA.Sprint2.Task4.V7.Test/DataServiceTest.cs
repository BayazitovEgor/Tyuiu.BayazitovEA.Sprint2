using Tyuiu.BayazitovEA.Sprint2.Task4.V7.Lib;
namespace Tyuiu.BayazitovEA.Sprint2.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;

            double y = 2;
            double res = ds.Calculate(x,y);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}

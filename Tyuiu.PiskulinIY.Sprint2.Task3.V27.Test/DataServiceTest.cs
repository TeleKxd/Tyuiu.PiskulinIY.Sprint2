using Tyuiu.PiskulinIY.Sprint2.Task3.V27.Lib;
namespace Tyuiu.PiskulinIY.Sprint2.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()

        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 1.491;
            Assert.AreEqual(wait , res);
        }

        [TestMethod] 
        public void ValidCondition2() 

        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.25;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()

        {
            DataService ds = new DataService();
            double x = -1;
            double res = ds.Calculate(x);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()

        {
            DataService ds = new DataService();
            double x = -32;
            double res = ds.Calculate(x);
            double wait = -32.865;
            Assert.AreEqual(wait, res);
        }
    }
}
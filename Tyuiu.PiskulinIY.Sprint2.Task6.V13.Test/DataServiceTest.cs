using Tyuiu.PiskulinIY.Sprint2.Task6.V13.Lib;
namespace Tyuiu.PiskulinIY.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string res = "2022-12-04";
            int g = 2022;
            int m = 12;
            int n = 03;
            Assert.AreEqual(res, ds.FindDateOfNextDay(g, m, n));
        }
    }
}
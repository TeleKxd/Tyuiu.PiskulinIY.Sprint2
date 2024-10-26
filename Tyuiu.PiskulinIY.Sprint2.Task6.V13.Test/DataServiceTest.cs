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
            int g = 2023;
            int m = 3;
            int n = 1;
            string expected = "Следующая дата: 2.3.2023";


            string result = ds.FindDateOfNextDay(g, m, n);


            Assert.AreEqual(expected, result);
        }
    }
}
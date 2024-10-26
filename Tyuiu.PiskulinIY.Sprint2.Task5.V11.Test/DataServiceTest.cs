using Tyuiu.PiskulinIY.Sprint2.Task5.V11.Lib;
namespace Tyuiu.PiskulinIY.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            


            DataService ds = new DataService();
            Assert.AreEqual("01.01.2005", ds.FindDateOfNextDay(2004, 12, 31));


        }
    }
}
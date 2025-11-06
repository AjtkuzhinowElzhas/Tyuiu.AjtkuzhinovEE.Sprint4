using Tyuiu.AjtkuzhinovEE.Sprint4.Task2.V5.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint4.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 3, 4, 5, 6, 7, 8, 9, 3, 4, 5, 6, 4, 7, 3 };
             var result = ds.Calculate(array);
            int wait = 18432;
            Assert.AreEqual(wait, result);

        }
    }
}

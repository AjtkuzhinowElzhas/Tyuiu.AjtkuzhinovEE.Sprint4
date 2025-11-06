using Tyuiu.AjtkuzhinovEE.Sprint4.Task1.V12.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint4.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();


            int[] array = { 4, 8, 6, 4, 9, 5, 8, 7, 8, 4, 7, 6, 8 };


            var res = ds.Calculate(array);
            int wait = 2205;
            Assert.AreEqual(wait, res);

        }
    }
}

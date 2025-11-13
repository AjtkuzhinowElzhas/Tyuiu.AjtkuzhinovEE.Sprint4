using Tyuiu.AjtkuzhinovEE.Sprint4.Task7.V20.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint4.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            
            int rows = 5;//n
            int columns = 3;//m
            int[,] matrix = new int[rows, columns];
            string str = "357951248632587";//value
            var result = ds.Calculate(rows, columns, str);
            int wait = 6144;
            Assert.AreEqual(wait, result);

        }
    }
}

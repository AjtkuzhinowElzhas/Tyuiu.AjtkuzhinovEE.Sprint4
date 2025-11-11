using Tyuiu.AjtkuzhinovEE.Sprint4.Task5.V9.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint4.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix =
            {
                { -2, 3, 0, 1,-1 },
                { 4, -3, 2, 0, 1 },
                { 0, 0, -4, 3, 2 },
                {-1, -2, 1, 4, 0 },
                { 3,  2,-3, 0,-4 }

            };
            // всего 11 положительных элементов (3,1,4,2,1,3,2,1,4,3,2)
            int wait = 11;
            int result = ds.Calculate(matrix);
            Assert.AreEqual(wait, result);



        }
    }
}

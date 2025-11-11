using Tyuiu.AjtkuzhinovEE.Sprint4.Task4.V28.Lib;


namespace Tyuiu.AjtkuzhinovEE.Sprint4.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[,] {     { 3, 3, 1, 1, 4 },
                                             { 2, 4, 2, 1, 5 },
                                             { 2, 2, 2, 2, 2 },
                                             { 1, 5, 4, 5, 4 },
                                             { 1, 2, 3, 2, 4 } };
            var result = ds.Calculate(matrix);


            int[,] wait = new int   [,] {    { 3, 3, 1, 1, 1 },
                                             { 1, 1, 1, 1, 5 },
                                             { 1, 1, 1, 1, 1 },
                                             { 1, 5, 1, 5, 1 },
                                             { 1, 1, 3, 1, 1 } };
            
            CollectionAssert.AreEqual(wait, result);
        }
    }
}

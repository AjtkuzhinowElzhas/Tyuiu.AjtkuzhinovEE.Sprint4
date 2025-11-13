using Tyuiu.AjtkuzhinovEE.Sprint4.Task6.V3.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint4.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()

        {
            DataService ds = new DataService();
            
            //months - месяцы
            string[] months = { "Январь", "Февраль", "Март",
                                "Апрель", "Май", "Июнь",
                                "Июль", "Август", "Сентябрь",
                             "Октябрь", "Ноябрь", "Декабрь" };
            var result = ds.Calculate(months);
            var wait = 4;
            Assert.AreEqual(wait, result);
        }
    }
}

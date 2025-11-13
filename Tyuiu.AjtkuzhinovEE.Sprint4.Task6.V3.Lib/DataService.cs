using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AjtkuzhinovEE.Sprint4.Task6.V3.Lib
{
    public class DataService : ISprint4Task6V3
    {
        public int Calculate(string[] array)
        {
            string[] count = Array.FindAll(array, months => months.Length < 6);//FindAll-метод класса array обозначающий <<Найти всех>>
            return count.Length;
        }
    }
}

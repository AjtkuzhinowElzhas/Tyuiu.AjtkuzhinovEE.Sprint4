using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AjtkuzhinovEE.Sprint4.Task2.V5.Lib
{
    public class DataService : ISprint4Task2V5
    {
        public int Calculate(int[] array)
        {
            Random random = new Random();
            int lem = 14;
            int[] number = new int[lem];
            int result = 1;
            foreach (int num in array) 
            {
                if (num % 2 == 0)
                {
                    result *= num;
                }
                
            }
            return result;
        }
    }
}

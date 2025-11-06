using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AjtkuzhinovEE.Sprint4.Task1.V12.Lib
{
    public class DataService : ISprint4Task1V12
    {
        public int Calculate(int[] array)
        {

            int p = 1;// P - ЭТО произведение элементов(дальше указывается что это будет произведением тольконечётных элементов
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 != 0)
                {
                    p*= array[i];
                }
            
            }
            return p;
        }
    }
}

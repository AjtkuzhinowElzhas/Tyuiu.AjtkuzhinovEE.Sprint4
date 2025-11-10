using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AjtkuzhinovEE.Sprint4.Task3.V5.Lib
{
    public class DataService : ISprint4Task3V5
    {
        public int Calculate(int[,] array)
        {
            int[,] data = new int[5, 5] { { 3, 4, 8, 6, 3 },
                                         { 9, 9, 3, 6, 9 },
                                         { 5, 6, 7, 2, 3 },
                                         { 3, 6, 2, 3, 8 },
                                         { 5, 7, 2, 6, 4 } };
            int s = 0;
            for (int i = 0; i < array.GetLength(0); i++)//отвечает за строки
            {
                
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(j == 0)
                    {
                        s += array[i, j];
                    }
                    else { continue; }
                }

                
            }
            return s;
        }
        
    }
}

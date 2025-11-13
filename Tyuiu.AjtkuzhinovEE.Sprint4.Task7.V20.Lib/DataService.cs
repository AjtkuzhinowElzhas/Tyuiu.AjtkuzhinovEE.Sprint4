using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AjtkuzhinovEE.Sprint4.Task7.V20.Lib
{
    public class DataService : ISprint4Task7V20
    {
        public int Calculate(int n, int m, string value)//n- количество строк  m- количество столбцов value-строковое значение
        {
            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < m; j++) 
                {
                    matrix[i, j] = int.Parse(value.Substring(i * m + j, 1));

                }
                
            }

            int p = 1;

            for (int i = 0; i < n; ++i) 
            {
                for(int j = 0;j < m; j++)
                {
                    if( matrix[i, j] %2 == 0 )
                    {
                        p *= matrix[i, j];
                    }
                }
            }
            return p;
        }
    }
}

using Tyuiu.AjtkuzhinovEE.Sprint4.Task4.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("# УСЛОВИЕ:                                                                #");
        Console.WriteLine("# Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        #");
        Console.WriteLine("# статическими значениями в диапазоне от 1 до 5. Заменить чётные элементы #");
        Console.WriteLine("# массива на 1                                                            #");
        Console.WriteLine("# 3, 3, 1, 1, 4,                                                          #");
        Console.WriteLine("# 2, 4, 2, 1, 5,                                                          #");
        Console.WriteLine("# 2, 2, 2, 2, 2,                                                          #");
        Console.WriteLine("# 1, 5, 4, 5, 4,                                                          #");
        Console.WriteLine("# 1, 2, 3, 2, 4,                                                          #");
        Console.WriteLine("###########################################################################");
        Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
        Console.WriteLine("###########################################################################");

        int[,] matrix = new int[,] {     { 3, 3, 1, 1, 4 },
                                             { 2, 4, 2, 1, 5 },
                                             { 2, 2, 2, 2, 2 },
                                             { 1, 5, 4, 5, 4 },
                                             { 1, 2, 3, 2, 4 } };
        var result = ds.Calculate(matrix);

        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] % 2 == 0)
                {
                    matrix[i, j] = 1;
                }
                else { continue; }
            }

        }


        Console.WriteLine("###########################################################################");
        Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
        Console.WriteLine("###########################################################################");

        Console.WriteLine(matrix);
        Console.ReadKey();
       


    }
}
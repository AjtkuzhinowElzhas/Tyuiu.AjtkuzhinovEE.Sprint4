using Tyuiu.AjtkuzhinovEE.Sprint4.Task3.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая подсчитывает сумму элементов первого сто -  *");
        Console.WriteLine("* лбца в двумерном массиве                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int[,] Array = new int[5, 5] { { 3, 4, 8, 6, 3 }, { 9, 9, 3, 6, 9 },
               { 5, 6, 7, 2, 3 }, { 3, 6, 2, 3, 8 }, { 5, 7, 2, 6, 4 } };
        int rows = Array.GetUpperBound(0) + 1;
        int columns = Array.Length / rows;

        Console.WriteLine("Массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{Array[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Сумма элементов первого столбца " + ds.Calculate(Array));
        Console.ReadKey();
    }
}
using Tyuiu.AjtkuzhinovEE.Sprint4.Task5.V9.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();

        Console.WriteLine("###########################################################################");
        Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
        Console.WriteLine("###########################################################################");
        Console.WriteLine("Введите количество строк в массиве :                                       ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов в массива:                                     ");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, columns];
        Console.WriteLine("###########################################################################");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = rnd.Next(-4, 4);
            }
        }
        Console.WriteLine("\nМассив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine($"{matrix[i, j]}   \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("###########################################################################");
        Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
        Console.WriteLine("###########################################################################");
        int result = ds.Calculate(matrix);
        Console.WriteLine("Количество положительных элементов массива = " + result);
        Console.ReadKey();

    }
}
using Tyuiu.AjtkuzhinovEE.Sprint4.Task7.V20.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт №4 | Выполнил: Айткужинов Е. Е. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнил: Айткужинов Елжас      | РППб-25-1                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр '357951248632587'.                    *");
        Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3                                        *");
        Console.WriteLine("* и подсчитайте произведение четных чисел.                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int rows = 5;
        int columns = 3;
        int[,] matrix = new int[rows, columns];
        string str = "357951248632587";
        int index = 0;

        Console.WriteLine("\nМассив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();
        }

        Console.WriteLine();


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(rows, columns, str);

        Console.WriteLine("Произведение чётных элементов = " + res);
        Console.ReadKey();
    }
}
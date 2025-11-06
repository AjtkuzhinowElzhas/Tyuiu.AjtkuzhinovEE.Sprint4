using Tyuiu.AjtkuzhinovEE.Sprint4.Task2.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
        Console.WriteLine("* лучайными в диапазоне от 3 до 9 подсчитать произведение четных          *");
        Console.WriteLine("* элементов массива.                                                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[] array = new int[] { 5, 5, 7, 4, 9, 5, 3, 5, 7, 5, 5, 4, 8, 5 };
        int result = ds.Calculate(array);
        Console.WriteLine("Массив состоит из набора 14 случайных чисел в диапозоне от 3 до 9          ");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
        Console.WriteLine("***************************************************************************");

        /*if (hasEven)
        {
            Console.WriteLine($"Сумма всех четных чисел массива {string.Join(", ", numbers)} равна {result}");
        }
        else
        {
            Console.WriteLine("В массиве нет четных чисел");
        }*/

        Console.WriteLine($"Произведение всех четных чисел массива {string.Join(", ", array)} равна {result}");
    }
}
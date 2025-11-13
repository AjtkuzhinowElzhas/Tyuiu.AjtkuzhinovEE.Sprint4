using Tyuiu.AjtkuzhinovEE.Sprint4.Task6.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строковый массив данных {Январь, Февраль, Март, Апрель, Май, Июнь,  *");
        Console.WriteLine("* Июль, Август, Сентябрь, Октябрь , Ноябрь, Декабрь}                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        var a = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

        Console.WriteLine();

        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.Write("Количество элементов длина которых < 6 = " + ds.Calculate(a));
        Console.ReadKey();
    }
}
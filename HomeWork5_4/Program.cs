using System;

namespace HomeWork5_4
{
    class Program
    {
        //Сформировать одномерный массив из 20 случайных чисел в диапазоне[-50;50].
        //Определить количество нечетных положительных элементов, стоящих на четных местах.
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            int numberCount = 0;
            Random random = new Random();
            Console.WriteLine("Вывод на экран значенй массива:");
            for (int i = 0; i < n; i++)     //заполнение массива случайными числами и вывод их значений на экран
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Перечисление нечетных положительных элементов, стоящих на четных местах");
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 != 0 && i % 2 == 0 && array[i] > 0)
                {
                    numberCount++;
                    Console.Write("{0} ", array[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах {0}", numberCount);
            Console.ReadKey();
        }
    }
}

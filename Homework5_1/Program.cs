using System;

namespace Homework5_1
{
    class Program
    {
        // Сформировать одномерный массив из 7 элементов.Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.
        static void Main(string[] args)
        {
            const int n = 7;
            double[] array = new double[n];
            double Summ = 0;
            Console.WriteLine("Введите элементы массива в кол-ве 7 шт. с клавиатуры: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());
                Summ += array[i];
            }
            Console.WriteLine("Среднее арифметическое элементов массива {0:f2}", Summ/n);
        }
    }
}

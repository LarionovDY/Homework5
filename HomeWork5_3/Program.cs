using System;

namespace HomeWork5_3
{
    class Program
    {
        //Сформировать одномерный массив из 10 случайных чисел в диапазоне[-50;50].
        //Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            Console.WriteLine("Вывод на экран значенй массива:");
            for (int i = 0; i < n; i++)     //заполнение массива случайными числами и вывод их значений на экран
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }

            for (int i = 0; i < n / 2 - 1; i++) //сортировка первой половины массива по возрастанию
            {
                for (int j = i + 1; j < n / 2; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }

            for (int i = n / 2; i < n - 1; i++) //сортировка второй половины массива по убыванию
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Вывод на экран отсортированного массива:");
            foreach (int a in array)
            {
                Console.Write("{0} ", a);
            }
            Console.ReadKey();
        }
    }
}

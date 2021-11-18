using System;

namespace HomeWork5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50].
            //Определить сумму максимального и минимального элементов массива.
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            Console.WriteLine("Вывод на экран значенй массива:");
            for (int i = 0; i < n; i++)     //заполнение массива случайными числами и вывод их значений на экран
            {
                array[i] = random.Next(0, 50);                
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            int max = array[0];
            foreach (int b in array)    //поиск максимального элемента массива
            {
                if (b > max)
                    max = b;
            }

            int min = array[0];
            foreach (int a in array)    //поиск минимального элемента массива
            {
                if (a < min)
                    min = a;
            }       
            
            Console.WriteLine("Максимальный элемент массива: {0}, минимальный: {1}, сумма элементов: {2}", max, min, max+min);
            Console.ReadKey();
        }
    }
}

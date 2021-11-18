using System;

namespace HomeWork5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:

                                                                                                                1 0 1 0 1

                                                                                                                0 1 0 1 0

                                                                                                                1 0 1 0 1

                                                                                                                0 1 0 1 0

                                                                                                                1 0 1 0 1 */

            
            Console.WriteLine("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int[,] array = new int[n, n];
            Console.WriteLine("Введите поочередно элементы массива: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)     //формирование и вывод матрицы
                {
                    array[i, j] = 1 - (i + j) % 2;
                    Console.Write("{0} ", array[i, j]);                    
                }
                Console.WriteLine();
            }            
            Console.ReadKey();
        }
    }
}

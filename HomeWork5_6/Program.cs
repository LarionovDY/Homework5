using System;

namespace HomeWork5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя целочисленное значение N.
            //Сформировать двумерный массив размера NxN.Заполнить массив числами, вводимыми с клавиатуры.
            //Проверить, является ли введенная с клавиатуры матрица магическим квадратом.
            //Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.

            Console.WriteLine("Введите размерность матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int[,] array = new int[n, n];
            int column = 0, line = 0, summColumn = 0, summLine = 0, summDiag1 = 0, summDiag2 = 0;
            int magicConst = n * (n * n + 1) / 2;
            Console.WriteLine("Введите поочередно элементы матрицы: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)     //формирование  матрицы
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("Введенная матрица: ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)     //вывод матрицы на экран монитора
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();           

            for (int i = 0; i < n; i++)     //подсчет сумм строк, столбцов и диагоналей
            {
                column = 0;
                line = 0;
                for (int j = 0; j < n; j++)
                {                                     
                    column += array[i, j];
                    line += array[j, i];
                    if (i == j)
                    {
                        summDiag1 += array[i, j];
                    }
                    if (i == n - j - 1)
                    {
                        summDiag2 += array[i, j];
                    }
                }
                if (column == magicConst || line == magicConst)
                {
                    summColumn = column;
                    summLine = line;
                }
                else
                {
                    break;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Матрица {0} магическим квадратом", magicConst == summColumn && summColumn == summLine && summLine == summDiag1 && summDiag1 == summDiag2 ? "является" : "не является");
            Console.ReadKey();
        }
    }
}

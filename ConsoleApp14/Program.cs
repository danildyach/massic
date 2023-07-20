using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов : ");
            int n = Convert.ToInt32(Console.ReadLine());
            zd47(m, n);
            Console.WriteLine("задайте координаты :");
            Console.WriteLine("Строки :");
            int lin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Столбцы :");
            int col = Convert.ToInt32(Console.ReadLine());
            zd50(lin, col);
            Console.WriteLine("Задание 52");
            zd52();
        }
        static void zd47(int m, int n)
        {
            //Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

            //m = 3, n = 4.
            //0,5 7 - 2 - 0,2
            //1 - 3,3 8 - 9,9
            //8 7,8 - 7,1 9
            double[,] array = new double[m, n];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.NextDouble();


                }


            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]:F2} ");
                }
                Console.WriteLine();
            }

        }
        static void zd50(int lin, int col)
        {
            //Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
            //и возвращает значение этого элемента или же указание, что такого элемента нет.
            ////Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //17->такого числа в массиве нет
            Random rnd = new Random();
            int lines = rnd.Next(4, 6);
            int columns = rnd.Next(4, 6);
            int[,] array = new int[lines, columns];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(10);
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            if (lin >= lines || col >= columns)
            {
                Console.WriteLine("такого числа в массиве нет");
            }
            else
            {
                Console.WriteLine($"Число = {array[lin, col]}");
            }
        }
        static void zd52()
        {
            //Задача 52.Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце.
            ////Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
            Random rnd = new Random();
            int lines = rnd.Next(4, 6);
            int columns = rnd.Next(4, 6);
            int[,] array = new int[lines, columns];
            int[] col = new int[columns];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    col[j] += array[i, j];
                }
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {

                Console.Write(((float)col[i] / lines) + " ");
            }
            Console.WriteLine();

        }
    }
}


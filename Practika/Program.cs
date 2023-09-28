﻿using System;
using System.Text.RegularExpressions;

namespace CreativeDZ_23_09
{
    class Program
    {
        //Задание 4 
        public enum week
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
        static void Main(string[] args)
        {
            
            // Упражнение 1
            Console.WriteLine("Упражнение 1.");
            Random rand = new Random();
            int[] a = new int[10];
            Console.WriteLine("Последовательность чисел:");
            for (int j = 0; j < 10; j++)
            {
                a[j] = rand.Next(10);
                Console.Write( a[j] + " ");
            }
            int i = 0;
            for (; i < 10; i++)
            {
                if (a[i] > a[i + 1])
                {
                    break;
                }
            }
            if (i < 10)
            {
                Console.WriteLine($"\nПоследовательность не упорядочена. Порядковый номер числа, которое нарушает последовательность: {i+2}") ;
            }
            else
            {
                Console.WriteLine("Последовательность упорядочена");
            }

           // Упражнение 4
            Console.WriteLine("\nУпражнение 4.\nВведите число от 1 до 7: ");
            try
            {
                byte day = Convert.ToByte(Console.ReadLine());
                switch (day)
                {
                    case 
                        ((byte)week.Monday): Console.WriteLine("Понедельник"); 
                        break;
                    case 
                        ((byte)week.Tuesday): Console.WriteLine("Вторник"); 
                        break;
                    case 
                        ((byte)week.Wednesday): Console.WriteLine("Среда"); 
                        break;
                    case 
                        ((byte)week.Thursday): Console.WriteLine("Четверг"); 
                        break;
                    case 
                        ((byte)week.Friday): Console.WriteLine("Пятница"); 
                        break;
                    case 
                        ((byte)week.Saturday): Console.WriteLine("Суббота"); 
                        break;
                    case 
                        ((byte)week.Sunday): Console.WriteLine("Воскресенье"); 
                        break;
                    default: 
                        Console.WriteLine("Неправильно введено число"); 
                        break;
                }
            }
            catch(System.OverflowException)
            {
                Console.WriteLine("Неправильно введено число");
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Неправильный формат введеных данных");
            }

            //Упражнение 5
            Console.WriteLine("Упражнение 5");
            string[] dools = { "Hello Kitty", "Barbie doll", "qwerty", "Barbie doll", "qwerty", "Hello Kitty"};
            int count = 0;
            foreach(string index in dools)
            {
                if ((index == "Barbie dool") || (index == "Hello Kitty"))
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"Количество кукол в сумке равно: {count}");
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();

            // Упражнение 2
            Console.WriteLine("Упражнение 2");
            Console.WriteLine("Введите порядковый номер карты(от 6 до 14):");
            int number;
            try
            {
                number = int.Parse(Console.ReadLine());
                if (number < 6 || number > 14)
                {
                    throw new ArgumentException("Неправильный номера карты. Номер должен быть от 6 до 14");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неправильный ввод, должно быть число");
                Console.WriteLine("Нажмите Enter");
                Console.ReadKey();
                return;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Неправильный ввод числа, должно быть от 7 до 14");
                Console.WriteLine("Для продолжения нажмите Enter");
                Console.ReadKey();
                return;
            }
            try
            {
                if (number ==14)
                {
                    Console.WriteLine("Наимнование карты: Туз");
                }
                else if (number == 13)
                {
                    Console.WriteLine("наимнование карты: Король");
                }
                else if (number == 12)
                {
                    Console.WriteLine("Наименование карты: Дама");
                }
                else if (number == 11)
                {
                    Console.WriteLine("Наименование карты: Валет");
                }
                else
                {
                    Console.WriteLine($"Достоинство карты {number}");
                }
            } catch (Exception)
            {
                Console.WriteLine("Ошибка");
                Console.WriteLine("Для продолженния нажмите Enter");
                Console.ReadKey();
            }
            finally
            {
                Console.WriteLine("Нажмите Enter");
                Console.ReadKey();
            }
        }
    }
}
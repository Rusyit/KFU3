using System;
using System.Diagnostics;

namespace Tumakov4
{
    class Program
    {
        static void Main(string[] args)
        {

            // Упражнение 4.2.
            Console.WriteLine("Упражнение 4.1. + 4.2.");

            try
            {

                Console.Write("Введите номер дня (от 1 до 365): ");
                int day = int.Parse(Console.ReadLine());

                if ((day < 1) || (day > 365))
                {
                    Console.WriteLine("Вы ввели число меньше 1 или больше 365");
                }
                else {
                    DateTime dateTime = new DateTime(2023, 1, 1).AddDays(day - 1);

                    switch (dateTime.Month)
                    {
                        case 01:
                            Console.WriteLine($"{dateTime.Day} Января");
                            break;
                        case 02:
                            Console.WriteLine($"{dateTime.Day} Февраля");
                        break;
                        case 03:
                            Console.WriteLine($"{dateTime.Day} Марта");
                            break;
                        case 04:
                            Console.WriteLine($"{dateTime.Day} Апреля");
                            break;
                        case 05:
                            Console.WriteLine($"{dateTime.Day} Мая");
                            break;
                        case 06:
                            Console.WriteLine($"{dateTime.Day} Июня");
                            break;
                        case 07:
                            Console.WriteLine($"{dateTime.Day} Июля");
                            break;
                        case 08:
                            Console.WriteLine($"{dateTime.Day} Августа");
                            break;
                        case 09:
                            Console.WriteLine($"{dateTime.Day} Сентября");
                            break;
                        case 10:
                            Console.WriteLine($"{dateTime.Day} Октября");
                            break;
                        case 11:
                            Console.WriteLine($"{dateTime.Day} Ноября");
                            break;
                        case 12:
                            Console.WriteLine($"{dateTime.Day} Декабря");
                            break;
                        }
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Вы ввели не число или оно не является целым");
                }
                catch (Exception dateException)
                {
                    Console.WriteLine(dateException.Message);
                }

            // Лаботараторная работа 4 
            Console.WriteLine("Упражнение 4");

            try
            {
                int year = 2023;
                Console.Write("Введите количество дней в году: ");
                int yearDays = int.Parse(Console.ReadLine());
                Console.Write($"Введите номер дня (от 1 до {yearDays}): ");
                int day = int.Parse(Console.ReadLine());

                if ((yearDays != 366) && (yearDays != 365))
                {
                    throw new Exception($"Неправильный ввод данных, в году не может быть {yearDays} дней");
                }

                if ((day < 1) || (day > yearDays))
                {
                    throw new Exception($"Неправильный ввод данных, вы ввели число меньше 1 или больше {yearDays}");
                }

                if (yearDays % 5 != 0)
                {
                    year ++;
                }

                DateTime dateTime = new DateTime(year, 1, 1).AddDays(day - 1);

                switch (dateTime.Month)
                {
                    case 01:
                        Console.WriteLine($"{dateTime.Day} Января");
                        break;
                    case 02:
                        Console.WriteLine($"{dateTime.Day} Февраля");
                        break;
                    case 03:
                        Console.WriteLine($"{dateTime.Day} Марта");
                        break;
                    case 04:
                        Console.WriteLine($"{dateTime.Day} Апреля");
                        break;
                    case 05:
                        Console.WriteLine($"{dateTime.Day} Мая");
                        break;
                    case 06:
                        Console.WriteLine($"{dateTime.Day} Июня");
                        break;
                    case 07:
                        Console.WriteLine($"{dateTime.Day} Июля");
                        break;
                    case 08:
                        Console.WriteLine($"{dateTime.Day} Августа");
                        break;
                    case 09:
                        Console.WriteLine($"{dateTime.Day} Сентября");
                        break;
                    case 10:
                        Console.WriteLine($"{dateTime.Day} Октября");
                        break;
                    case 11:
                        Console.WriteLine($"{dateTime.Day} Ноября");
                        break;
                    case 12:
                        Console.WriteLine($"{dateTime.Day} Декабря");
                        break;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Неправильный ввод данных, вы ввели не число или оно не является целым");
            }
            catch (Exception dateException)
            {
                Console.WriteLine(dateException.Message);
            }
        }
    }
}
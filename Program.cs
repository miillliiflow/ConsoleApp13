using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

            //Задача 1. Дано целое число n, указывающее номер дня недели от 1 до 7. По указанному номеру n вывести название соответствующего дня недели.

            //Console.WriteLine("Введите номер дня недели: ");
            //int n = int.Parse(Console.ReadLine());
            //switch (n)
            //{
            //    case 1:
            //        Console.WriteLine("понедельник"); break;
            //    case 2:
            //        Console.WriteLine("вторник"); break;
            //    case 3:
            //        Console.WriteLine("среда"); break;
            //    case 4:
            //        Console.WriteLine("четверг"); break;
            //    case 5:
            //        Console.WriteLine("пятница"); break;
            //    case 6:
            //        Console.WriteLine("суббота"); break;
            //    case 7:
            //        Console.WriteLine("вокресенье"); break;
            //}

            //Задача 2. В зависимости от порядкового номера месяца (1, 2, ... , 12) вывести на экран его название (январь, февраль, ... , декабрь).

            //Console.WriteLine("Введите номер месяца: ");

            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("январь"); break;
            //    case 2:
            //        Console.WriteLine("февраль"); break;
            //    case 3:
            //        Console.WriteLine("март"); break;
            //    case 4:
            //        Console.WriteLine("апрель"); break;
            //    case 5:
            //        Console.WriteLine("май"); break;
            //    case 6:
            //        Console.WriteLine("июнь"); break;
            //    case 7:
            //        Console.WriteLine("июль"); break;
            //    case 8:
            //        Console.WriteLine("август"); break;
            //    case 9:
            //        Console.WriteLine("сентябрь"); break;
            //    case 10:
            //        Console.WriteLine("октябрь"); break;
            //    case 11:
            //        Console.WriteLine("ноябрь"); break;
            //    case 12:
            //        Console.WriteLine("декабрь"); break;
            //}

            // Задача 3.По номеру месяца вывести название времени года.

            //Console.WriteLine("Введите номер месяца: ");
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //    case 2:
            //    case 12:
            //        Console.WriteLine("зима"); break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("весна"); break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("лето"); break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("осень"); break;
            //    default:
            //        Console.WriteLine("Такого номера месяца не существует"); break;
            //}

            //Задача 4.Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.

            Console.WriteLine("Введите первую букву предмета: ");
            char n = char.Parse(Console.ReadLine());
            switch (n)
            {
                case 'ф':
                case 'Ф':
                    Console.WriteLine("физика"); break;
                case 'м':
                case 'М':
                    Console.WriteLine("математика"); break;
                case 'и':
                case 'И':
                    Console.WriteLine("история"); break;
                case 'г':
                case 'Г':
                    Console.WriteLine("география"); break;
                case 'б':
                case 'Б':
                    Console.WriteLine("биология"); break;
            }

                Console.ReadKey();
        }
    }
}

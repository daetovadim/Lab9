using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            int X = 0;
            int Y = 0;

            try
            {
                Console.Write("Введите целое число X = ");
                X = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите целое число Y = ");
                Y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Операции:");
                Console.WriteLine("\t1 - сложение");
                Console.WriteLine("\t2 - вычитание");
                Console.WriteLine("\t3 - произведение");
                Console.WriteLine("\t4 - частное");
                Console.Write("Введите номер операции: ");

                int num = 0;
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num == 1)
                        Console.WriteLine("Ваш результат: {0}", X + Y);
                    else if (num == 2)
                        Console.WriteLine("Ваш результат: {0}", X - Y);
                    else if (num == 3)
                        Console.WriteLine("Ваш результат: {0}", X * Y);
                    else if (num == 4)
                        Console.WriteLine("Ваш результат: {0}", X / Y);
                    else
                        Console.WriteLine("Нет операции с указанным номером");
                }
                catch when (num == 4 && Y == 0)
                {
                    Console.WriteLine("Ошибка! Попытка деления на ноль.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введённый номер не является числом.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введённые данные не являются числом.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }            

            Console.ReadKey();
        }
    }
}

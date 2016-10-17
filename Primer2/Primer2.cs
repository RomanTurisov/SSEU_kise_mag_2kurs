using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            if (int.TryParse(Console.ReadLine(), out A))
            {
                if (int.TryParse(Console.ReadLine(), out B))
                {
                    //максимальное значение
                    int Max;
                    //если больше A
                    if (A >= B)
                    {
                        Max = A;
                    }
                    //инчае больеш B
                    else
                    {
                        Max = B;
                    };
                    //вывод результата
                    Console.WriteLine("Максимальное = " + Max);
                }
                else
                {
                    Console.WriteLine("Неверное знаечение! Нужно ввести целое число.");
                };
            }
            else
            {
                Console.WriteLine("Неверное знаечение! Нужно ввести целое число.");
            }
            //завершение программы
            Console.ReadKey();
        }

    }
}

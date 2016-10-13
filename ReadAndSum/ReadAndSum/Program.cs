using System;
using System.Collections.Generic;
using System.Text;

namespace ReadAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //ввод исходных данных
            int A, B;
            int.TryParse(Console.ReadLine(), out A);
            int.TryParse(Console.ReadLine(), out B);
            //максимальное значение
            int Max;
            //если больше A
            if (A >= B)
            {
                Max = A;
            }
            //иначе больше B
            else
            {
                Max = B;
            }
            //вывод результата
            Console.WriteLine("Максимальное = " + Max);
            //завершение программы
            Console.ReadKey();
        }
            
    }
}

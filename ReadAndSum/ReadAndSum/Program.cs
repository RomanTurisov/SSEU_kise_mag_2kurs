using System;
using System.Collections.Generic;
using System.Text;

namespace ReadAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //���� �������� ������
            int A, B;
            int.TryParse(Console.ReadLine(), out A);
            int.TryParse(Console.ReadLine(), out B);
            //������������ ��������
            int Max;
            //���� ������ A
            if (A >= B)
            {
                Max = A;
            }
            //����� ������ B
            else
            {
                Max = B;
            }
            //����� ����������
            Console.WriteLine("������������ = " + Max);
            //���������� ���������
            Console.ReadKey();
        }
            
    }
}

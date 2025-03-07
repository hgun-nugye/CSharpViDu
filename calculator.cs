using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char phepToan;
            double ketQua = 0;

            Console.Write("Nhap a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhap phep toan (+,-,*,/): ");
            phepToan = char.Parse(Console.ReadLine());

            switch (phepToan)
            {
                case '+':
                    ketQua = a + b; break;
                case '-':
                    ketQua = a - b; break;
                case '*':
                    ketQua = a * b; break;
                case '/':
                    if (b != 0) ketQua = (double) a / b; break;
                default:
                    Console.WriteLine("Error!"); break;
            }
            if (b != 0)
            {
                Console.Write("Ket qua la: ");
                Console.WriteLine($"{a} {phepToan} {b} = {ketQua}");
            }
            else
                Console.WriteLine("Error!");
        }
    }
}
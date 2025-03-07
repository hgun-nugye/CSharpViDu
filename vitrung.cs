using System;

namespace vitrung
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so luong vi trung ban dau: ");
            int n = int.Parse(Console.ReadLine());
            int n0 = n;

            Console.WriteLine("Nhap vao thoi gian vi trung nhan doi: ");
            int h = int.Parse(Console.ReadLine());

            for (int i = 0; i < h; i++)
            {
                n*= 2;
            }
            Console.WriteLine($"Sau {h} gio, {n0} vi trung nhan doi thanh {n} con.");
        }
    }
}

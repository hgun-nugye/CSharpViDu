using System;

namespace ElectricityBill
{
    internal class Program
    {
        const int Muc1 = 100, Muc2 = 150, Muc3 = 300;
        const float Gia1 = 2000, Gia2 = 2500, Gia3 = 3000;
        static void Main(string[] args)
        {
            int soKWh=0;
            double Bill = 0;

            Console.Write("Nhap vao so kWh da dung: ");
            soKWh = Convert.ToInt32(Console.ReadLine());

            if (soKWh <= Muc1)
            {
                Bill = soKWh * Gia1;
            }
            else if (soKWh > Muc1 && soKWh <= Muc2)
            {
                Bill = Muc1 * Gia1 + (double)(soKWh - Muc1) * Gia2;
            }
            else if (soKWh <= Muc3)
            {
                Bill = Muc1 * Gia1 + (Muc2 - Muc1) * Gia2 + (double)(soKWh - Muc2) * Gia3;
            }
            else
            {
                Bill = Muc1 * Gia1 + (Muc2 - Muc1) * Gia2 + (double)(soKWh - Muc2) * Gia3;
                Bill += Bill * 0.1f;
            }

            Console.Write("Day la so tien dien can dong: " + Bill);
        }
    }
}

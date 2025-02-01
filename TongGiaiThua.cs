using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    internal class TongGiaiThua
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap vao n: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 1);
            long sum = 0;
            int tg = 1;
            for (int i = 1; i <= n; i++)
            {
                tg *= i;
                sum += tg;
                
            }
            Console.WriteLine("Tong giai thua la " +sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    internal class CheckSNT
    {
        public static bool SNT(out int n)
        {
            do
            {
                Console.Write("Nhap vao n: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            for(int i = 2; i<= n/2; i ++)
            {
                if(n%i==0)
                {
                    return false;
                    break;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n;
            if(SNT(out n)) Console.WriteLine("{0} la so nguyen to.",n);
            else Console.WriteLine("{0} khong phai so nguyen to.",n);
        }
    }
}

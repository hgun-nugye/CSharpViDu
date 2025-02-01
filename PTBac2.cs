using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPTBac2
{
    public class PTBac2
    {
        public static void GiaiPTBac2(out int a,out int b,out int c)
        {
            Console.WriteLine("Nhap vao he so lan luot a, b, c: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                if(b == 0)
                {
                    if(c == 0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem.");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem.");
                    }

                }
                else
                {
                    Console.WriteLine("Phuong trinh co duy nhat nghiem : {0}",Math.Round((double)c / -b),4);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if(delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem.");
                }
                else if(delta==0)
                {
                    double x = -b / 2 / a;
                    Console.WriteLine("Phuong trinh co nghiem kep la: {0}", x); 
                }
                else
                {
                    double x1=Math.Round(((-b - Math.Sqrt(delta)) / 2 / a),4);
                    double x2=Math.Round(((-b + Math.Sqrt(delta)) / 2 / a),4);
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet la: {0} va {1}", x1, x2);
                }
            }
        }
        static void Main(string[] args)
        {
            int a, b, c;
            GiaiPTBac2(out a,out b,out c);
        }
    } 
}

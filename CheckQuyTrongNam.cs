using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class CheckQuyTrongNam
    {
        public static void CheckQuy(out int month)
        {
            do
            {
                Console.WriteLine("Nhap vao thang trong nam: ");
                month =int.Parse(Console.ReadLine());
            } while (month < 1 || month > 12);
            
            if(month < 3)
            {
                Console.WriteLine("Thang {0} thuoc quy 1.", month);
            }
            else if(month < 6)
            {
                Console.WriteLine("Thang {0} thuoc quy 2.", month);
            }
            else if (month < 9)
            {
                Console.WriteLine("Thang {0} thuoc quy 3.", month);
            }
            else
            {
                Console.WriteLine("Thang {0} thuoc quy 4.", month);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int month;
            CheckQuyTrongNam.CheckQuy(out month);
        }
    }

}

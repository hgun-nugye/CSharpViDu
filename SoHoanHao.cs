using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class SoHoanHao
    {
        /*Tìm số hoàn hảo từ 1 đến 1000*/
        static void Main(string[] args)
        {
            Console.Write("So hoan hao can tim trong day la:");
            for (int i = 1; i <= 1000; i++)
            {
                int tong = 0;
                for (int j = 1; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        tong += j;
                    }
                }
                if (tong == i)
                {
                    Console.Write(" " +i);
                }

            }
        }
    }
}

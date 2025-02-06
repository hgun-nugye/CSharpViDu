using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    internal class Mang2Chieu
    {
        static void Main(string[] args)
        {
            //1. khởi tạo mảng
            int[,] arr = new int[3, 5]; //khai báo mảng 2 chiều có 3 hàng 5 cột với các phần tử là số 0

            //2. khởi tạo và gán luôn giá trị cho mảng
            int[,] arr2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            //rút ngắn : int[,] mang2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //3. khởi tạo mảng ngẫu nhiên
            Random r = new Random();
            int dong = 4;
            int cot = 4;
            int[,] arr3=new int[dong, cot];
            for(int i = 0;i <dong; i++)
            {
                for(int j = 0;j < cot; j++)
                {
                    //Console.Write(i+ j +"\t");
                    arr3[i, j] = r.Next(0, 51);
                    Console.Write(arr3[i, j]+ "\t");
                }
                Console.WriteLine("\n");
            }

            //4. truy xuất phần tử qua GetLength(0) -> get dòng của mảng và GetLength(1) -> get cột của mảng
            Console.WriteLine("Day la mang random vua tao la: ");
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    //Console.Write(i+ j +"\t");
                    arr3[i, j] = r.Next(0, 51);
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

        }
    }
}

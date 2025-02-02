using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    internal class Random_DateTime
    {
        static void Main(string[] args)
        {
            //cú pháp tạo đối tượng tạo số ngẫu nhiên - random
            Random random = new Random();
            int a = random.Next(0, 101); //tạo số a ngẫu nhiên từ 0-begin đến 1000-end
            Console.WriteLine("Day la so ngau nhien kieu int vua duoc tao: "+a);

            //tạo số ngẫu nhiên kiểu double trong khoảng từ 0 đến 1
            double b = random.NextDouble();
            Console.WriteLine("Day la so ngau nhien kieu double vua duoc tao: " + b);

            //cú pháp tạo đối tượng tạo số ngày tháng
            DateTime birthday = new DateTime(1994,12,14);
            Console.WriteLine("\nNgay thang nam sinh cua ban la {0}. ", birthday.ToString("dd/MM/yyyy")) ;

            //tạo ngày tháng năm từ chuỗi
            DateTime day = DateTime.Parse("19/12/1997");
            Console.WriteLine("Ngay thang nam sinh cua ban la {0}. ", day.ToString("dd/MM/yyyy"));

            //Cho người dùng nhập vào ngày tháng năm
            Console.Write("Nhap vao ngay/thang/nam sinh: ");
            string s = Console.ReadLine();
            DateTime date = DateTime.Parse(s);
            Console.WriteLine("Ngay thang nam sinh cua ban vua nhap la {0}. ", date.ToString("dd/MM/yyyy"));


        }
    }
}

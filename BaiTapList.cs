using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    internal class BaiTapList
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Nhap vao so luong phan tu: ");
            n=int.Parse(Console.ReadLine());
            List<int> lst1= new List<int>(n);
            Random r = new Random();
            
            //tạo list ngẫu nhiên
            for(int i=0; i<n; i++)
            {
                lst1.Add(r.Next(101));
            }

            //xuất list ngẫu nhiên
            Console.WriteLine("Cac phan tu ngau nhien cua List vua tao la: ");
            foreach (int i in lst1)
            {
                Console.Write(i + " ");
            }

            //tạo list mới với giá trị bình phương các phần tử, đếm các phần tử lớn hơn 50 của list
            List<int> lst2 = new List<int>(n);
            int dem = 0;
            foreach (int i in lst1)
            {
                lst2.Add(i * i);
                if (i > 50) dem++;
            }
            Console.WriteLine("\n\nList gom cac phan tu duoc binh phuong len la: ");
            foreach(int i in lst2)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine("\nCo {0} phan tu binh phuong lon hon 50 cua list", dem);

            //đếm và xuất index các phần tử nhỏ hơn 5 của list
            dem = 0;
            List<int> Nho5 = new List<int>() { };

            foreach (int i in lst1)
            {
                if (i < 5)
                {
                    Nho5.Add(i);
                    dem++;
                }
            }
            Console.WriteLine("\nCo {0} phan tu ngau nhien nho hon 5 cua list", dem);
            if (dem != 0)
            {
                Console.WriteLine("Index cac phan tu nho hon 5 cua list la: ");
                foreach (int i in Nho5)
                {
                    Console.Write(lst1.IndexOf(i) + " ");
                }
            }

            //trả lời theo câu hỏi
            List<string> questions = new List<string>() { "2 + 5 + 7 =", "5*10 =", "sqrt(16) =", "12%2=", "5/2=" };
            List<int> answers = new List<int>() { 14, 50, 4, 0, 2 };
            
            int tt = 0;
            int dung = 0;
            int sai = 0;
            Console.WriteLine("\n\nTra loi cac cau hoi sau:");
            foreach (string question in questions)
            {
                Console.Write(question + " ");
                int answer =int.Parse(Console.ReadLine());
                if (answers[tt] == answer)
                {
                    Console.WriteLine("correct");
                    dung++;
                }
                else
                {
                    Console.WriteLine("Wrong, the answer is " + answers[tt]);
                    sai++;
                }
                    tt++;
            }
            Console.WriteLine("Ban da tra loi dung {0} cau, tra loi sai {1} cau", dung, sai);
            //tìm số lớn thứ 2 và nhỏ thứ 2 kèm theo index
            int Max = lst1.Max();
            int Min = lst1.Min();

            int max = lst1[0];
            int idmax = 0;
            int min = lst1[0];
            int idmin = 0;


            foreach (int i in lst1)
            {
                if(i>max && i<Max)
                {
                    max = i;
                    idmax = lst1.IndexOf(i);
                }

                if (i < min && i > Min)
                {
                    min = i;
                    idmin = lst1.IndexOf(i);
                }
            }
            Console.WriteLine("\nGia tri lon thu 2 la {0} va index la {1}", max, idmax);
            Console.WriteLine("Gia tri nho thu 2 la {0} va index la {1}", min, idmin);
            //cách khác:
            /* xóa Max và Min ban đầu của ds1, AddRange(ds1) vào ds2, tìm lại Max và Min của ds2, xác định vị trí của Max, Min mới thông qua IndexOf(value, ds1) so với ds1.*/
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    internal class Mang1Chieu
    {
        static void Main(string[] args)
        {
            //1. khai báo mảng
            int[] stt;
            char[] ch;

            //2. khởi tạo mảng
            stt = new int[10]; //các phần tử mặc định có giá trị 0 
            Console.WriteLine("Mang stt la:");
            foreach (int i in stt)
            {
                Console.Write(i + " ");
            }
            string[] mang = new string[50];
           
            //3. khởi tạo và gán giá tị cho mảng
            int[] so1 = new int[2] { 2 , 5};
            //rút ngắn
            int[] so2 = {1, 2, 3, 4, 5};

            //4. khởi tạo mảng ngẫu nhiên
            Random r =new Random();
            int[] mangrandom = new int[2] { r.Next(51), r.Next(61) };
            Console.WriteLine("\nMang random la: ");
            foreach (int i in mangrandom)
            {
                Console.Write(i + " ");
            }

            //5. Kiểm tra độ dài với Length
            Console.WriteLine("\nDo dai mang random la: ");
            Console.WriteLine(mangrandom.Length);

            //6. Truy xuất phần tử qua index
            int[] mangIndex= {1, 3, 5, 6};
            Console.WriteLine("Phan tu dau cua mang la: " + mangIndex[0]);
            Console.WriteLine("Phan tu cuoi cung cua mang la: " + mangIndex[mangIndex.Length-1]);

            //7. Thay đổi giá tị phần tử qua Index
            Console.WriteLine("Mang truoc khi doi gia tri la: ");
            foreach(int i in mangIndex)
            {
                Console.Write(i + " ");
            }
            mangIndex[2] = 8;
            Console.WriteLine("\nMang sau khi thay doi gia tri la:");
            foreach (int i in mangIndex)
            {
                Console.Write(i + " ");
            }

            //8. Phép gán mảng: gán mảng mới bằng mảng đã tồn tại
            int[] mangcu = { 1, 2, 3, };
            int[] mangmoi = mangcu;
            mangcu[0] = 100;
            Console.WriteLine("\nDay la gia tri thu nhat cua mang cu: " + mangcu[0]);
            Console.WriteLine("Day la gia tri thu nhat cua mang moi: " + mangmoi[0]);

            //9. CopyTo ->copy ra mảng mới trên vùng nhớ mới
            int[] mang1 = { 1, 2, 3, 7 };
            int[] mang2 = { 100, 200, 300, 400, 500, 600 };
            mang1.CopyTo(mang2, 2); // ghi đè mang1 từ vị trí index 2 của mang2, khi do mang 2 bi thay doi gia tri
            //neu gia tri ghi de ít hơn so phan tu sau vi tri ggi de, thi phan tu khong bi ghi de duoc giu nguyen
            foreach(int i in mang2 )
            {
                Console.Write(i + " ");
            }

            //10. Array.Copy(arr nguồn, arr đích, count) -> copy count phần tử từ arr nguồn nào arr đích.
            int[] nguon = { 1, 3, 5, 7, 9, 11 };
            int[] dich = new int[5];
            Array.Copy(nguon, dich, 5);
            Console.WriteLine("\nCac phan tu vua duoc copy cua mang dich la: ");
            foreach (int i in dich)
            {
                Console.Write(i + " ");
            }

            //11. Clone() -> copy hết phần tử mảng cũ sang mảng mới
            int[] oldArr = { 1, 3, 5, 7, 9, 11 };
            int[] newArr=(int[])oldArr.Clone();
            Console.WriteLine("\nCac phan tu vua duoc copy clone cua mang moi la: ");
            foreach (int i in newArr)
            {
                Console.Write(i + " ");
            }

            //12. Array.Reverse() -> đảo ngược mảng
            Console.WriteLine("\nMang moi sau khi duoc dao nguoc la:");
            Array.Reverse(newArr);
            foreach (int i in newArr)
            {
                Console.Write(i + " ");
            }

            //13. Array.Sort() -> sắp xếp mảng tăng dần            
            int[] mangSort = { 1, 7, 11, 9, 12, 19, -3 };
            Console.WriteLine("\nMang truoc khi duoc sap xep la:");
            foreach (int i in mangSort)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\nMang sau khi duoc sap xep la:");
            Array.Sort(mangSort);
            foreach (int i in mangSort)
            {
                Console.Write(i + " ");
            }
        }
    }
}

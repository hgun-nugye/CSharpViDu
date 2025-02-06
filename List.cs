using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    internal class List
    {
        static void Main(string[] args)
        {
            //1. khởi tạo list
            List<string> ds1 = new List<string>(); //khởi tạo danh sách mà các phần tử là string
            List<int> ds2 = new List<int>(); //khởi tạo danh sách mà các phần tử là số nguyên

            //2. khởi tạo danh sách có sẵn một số phần tử
            List<int> ds3 = new List<int>() { 1, 2, 3, 5, 11 };
            foreach (int i in ds3)
            {
                Console.Write(i + " ");
            }

            //3. Add(phần tử cần thêm), thêm phần tử vào cuối list
            List<int> ds4 = new List<int>() { 1, 2, 3 };
            ds4.Add(100);
            ds4.Add(200);
            Console.WriteLine("\n\nList4 sau khi them phan tu la: ");
            foreach (int i in ds4)
            {
                Console.Write(i + " ");
            }

            //4. Remove(objx) -> xóa phần tử obj đầu tiên tìm thấy trong list
            List<int> ds5 = new List<int>() { 1, 2, 3, 7, 11, 5, 1, 3, 5 };
            ds5.Remove(3);
            Console.WriteLine("\n\nList5 sau khi xoa phan tu 3 dau tien la: ");
            foreach (int i in ds5)
            {
                Console.Write(i + " ");
            }

            //5. int Count -> đếm số phần tử của danh sách ( giống Length trong mảng 1 chiều)
            List<int> ds6 = new List<int>() { 1, 3, 6, 11, 9, -2 };
            Console.WriteLine("\nList6: ");
            foreach (int i in ds6)
            {
                Console.Write(i + " ");
            }
            int dem = ds6.Count;
            Console.WriteLine("\n\nList6 co {0} phan tu.", dem);


            //6. Clear() -> xóa toàn bộ phần tử của danh sách đã tồn tại
            List<int> ds7 = new List<int>() { 6, 1, 5, 9, 11 };
            ds7.Clear(); // -> danh sách 7 sẽ là danh sách rỗng, không có phần tử.

            //7. AddRange(list) -> thêm toàn bộ list vào danh sách
            List<int> ds8 = new List<int>() { 5, 4, 3, 7, 8 };
            Console.WriteLine("\nDanh sach 8 truoc khi them ds9 la: ");
            foreach (int i in ds8)
            {
                Console.Write(i + " ");
            }
            List<int> ds9 = new List<int>() { 1, 5 };
            ds8.AddRange(ds9);
            Console.WriteLine("\n\nDanh sach 8 sau khi them ds9 la: ");
            foreach (int i in ds8)
            {
                Console.Write(i + " ");
            }

            //8. bool (ds).Contains(value) -> kiểm tra có tồn tại value trong ds không, có trả về Tru, không trả về False 
            List<int> ds10 = new List<int>() { 1, 5, 3, 7, 9, 12 };
            bool check = ds10.Contains(3);
            Console.WriteLine("\n\nCo ton tai gia tri 3 trong ds10 khong?");
            Console.WriteLine(check);

            //9. GetRange(int index, int count) -> trả về 1 list con, lấy từ index và count là số lượng phần tử cần lấy
            List<int> ds11 = new List<int>() { 1, 5, 3, 7, 9, 12 };
            List<int> ds12 = ds11.GetRange(2, 3);
            Console.WriteLine("\nDanh sach 12 sau khi GetRange tu ds11 la: ");
            foreach (int i in ds12)
            {
                Console.Write(i + " ");
            }

            //10. int IndexOf(value) -> trả về vị trí index tìm thấy value, không thấy trả về -1
            List<int> ds13 = new List<int>() { 1, 5, 3, 7, 9, 12 };
            int checkIndex = ds13.IndexOf(3);
            Console.Write("\n\nGia tri 3 trong ds13 o vi tri Index la:" + checkIndex);

            //11. Insert(index, value) -> chèn giá trị value vào vị trí index
            List<int> ds14 = new List<int>() { 1, 5, 3, 7, 9, 12 };
            ds14.Insert(0, 100);
            Console.WriteLine("\n\nDanh sach 14 sau khi chen them value 100 vao index 0 la: ");
            foreach (int i in ds14)
            {
                Console.Write(i + " ");
            }

            //12. InsertRange(index, ds chèn thêm) -> chèn thêm ds vào vị trí index
            List<int> ds15 = new List<int>() { 1, 5, 3, 7, 9, 12 };
            List<int> ds16 = new List<int>() { 2, 8 };
            Console.WriteLine("\n\nDanh sach 15 ban dau: ");
            foreach (int i in ds15)
            {
                Console.Write(i + " ");
            }
            ds15.InsertRange(1, ds16);
            Console.WriteLine("\nDanh sach 15 sau khi chen them ds16 vao index 1 la: ");
            foreach (int i in ds15)
            {
                Console.Write(i + " ");
            }

            //13. RemoveAt(int index) ->xóa phần tử tại vị trí index chỉ định
            List<int> ds17 = new List<int>() { 2, 8, 10, 15, 13 };
            Console.WriteLine("\n\nDanh sach 17 ban dau: ");
            foreach (int i in ds17)
            {
                Console.Write(i + " ");
            }
            ds17.RemoveAt(3);
            Console.WriteLine("\nDanh sach 17 sau khi xoa index 3 la: ");
            foreach (int i in ds17)
            {
                Console.Write(i + " ");
            }

            //14. RemoveRange(int index, int count) ->xóa count phần tử bắt đầu từ vị trí index
            List<int> ds18 = new List<int>() { 1, 3, 5, 7, 91, 15};
            Console.WriteLine("\n\nDanh sach 18 ban dau: ");
            foreach (int i in ds18)
            {
                Console.Write(i + " ");
            }
            ds18.RemoveRange(1, 2);
            Console.WriteLine("\nDanh sach 18 sau khi xoa 2 phan tu tai index 1 la: ");
            foreach (int i in ds18)
            {
                Console.Write(i + " ");
            }

            //15. ds.Reverse() -> đảo ngược danh sách
            List<int> ds19 = new List<int>() { 1, 3, 5, 7, 91, 15 };
            Console.WriteLine("\n\nDanh sach 19 ban dau: ");
            foreach (int i in ds19)
            {
                Console.Write(i + " ");
            }
            ds19.Reverse();
            Console.WriteLine("Danh sach 19 sau khi dao nguoc la: ");
            foreach (int i in ds19)
            {
                Console.Write(i + " ");
            }

            // 16.ds.Sort()-> sắp xếp tăng dần danh sách
            List<int> ds20 = new List<int>() { 1, 3, 5, 7, 91, 15 };
            Console.WriteLine("\n\nDanh sach 20 ban dau: ");
            foreach (int i in ds20)
            {
                Console.Write(i + " ");
            }
            ds20.Sort();
            Console.WriteLine("\nDanh sach 20 sau khi sap xep tang dan la: ");
            foreach (int i in ds20)
            {
                Console.Write(i + " ");
            }

            //17. BinarySearch(value) -> tìm kiếm value trong danh sách
            int timkiem = ds20.BinarySearch(3);
            //nếu ra giá trị âm tức là không tìm thấy
            Console.WriteLine("\n\nGia tri {0} o vi tri index {1} trong ds20", 3, timkiem);

            //Max(), Min() 
            int max = ds20.Max();
            int min = ds20.Min();
            Console.WriteLine("\n\nMax cua ds20: " + max);
            Console.WriteLine("Min cua ds20: " + min);


        }
    }

}

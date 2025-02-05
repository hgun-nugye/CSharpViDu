using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    internal class BaiTapMang1Chieu
    {
        public static void NhapMang(int n,ref int[] arr)
        {
            for(int i=0; i<n; i++)
            {
                Console.Write("Nhap vao phan tu thu {0}: ", i+1);
                arr[i]=int.Parse(Console.ReadLine());
            }

        }
        public static void XuatMang(int n,int[] arr)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static void DaoNguocMang(int n, int[] arr)
        {
            Array.Reverse(arr);
            XuatMang(n, arr);
        }
        public static void MangTangDan(int n, int[] arr)
        {
            Array.Sort(arr);
            XuatMang(n, arr);
        }
        public static void TongPhTu(int n, int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("\n\nTong cac phan tu cua mang la: " + sum);
        }
        public static void TimSo(int n, int[] arr)
        {
            int index = -1;
            Console.Write("\nNhap vao so can tim: ");
            int so=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == so)
                {
                    index = i; ;
                    break;
                }
            }
            //Hoặc tìm theo BinarySearch
            //index =Array.BinarySearch(arr, so);

            if(index!=-1)
                Console.WriteLine("So {0} can tim o vi tri index {1} ", so, index);
            else Console.WriteLine("Khong tim thay so "+ so);
        }

        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Nhap vao so luong phan tu cua mang: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
            int[] arr = new int[n];
            NhapMang(n,ref arr);
            Console.WriteLine("\n\nMang vua nhap la: ");
            XuatMang(n, arr);
            Console.WriteLine("\n\nMang duoc dao nguoc la: ");
            DaoNguocMang(n, arr);
            Console.WriteLine("\n\nMang duoc sap xep tang dan la: ");
            MangTangDan(n, arr);
            TongPhTu(n, arr);
            TimSo(n, arr);
        }
    }
}

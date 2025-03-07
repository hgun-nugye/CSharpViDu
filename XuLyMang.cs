using System;
using System.Text;

namespace XuLyMang
{
    internal class Program
    {
        /* a) Nhap mang n so nguyen tu ban phim*/
        static void NhapMang(ref int[] a, ref int n)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhap vao so luong phan tu cua mang:");
            n = int.Parse(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap vao phan tu thu " + i + " cua mang: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        /* b)In ra cac phan tu cua mang.*/
        static void XuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        /* c) Tra ve phan tu lon nhat cua mang.*/
        static int MaxMang(int[] a, int n)
        {
            int max = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        /* d)Mang duoc xep tang dan chua */
        static bool TangDan(int[] a, int n)
        {
            bool check = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i] > a[i+1])
                {
                    check = false;
                    break;
                }                
            }
            return check;
        }
        /*e) Sap xep mang tang dan */
        static void XepTangDan(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        a[i] = a[i] ^ a[j];
                        a[j] = a[i] ^ a[j];
                        a[i] = a[i] ^ a[j];
                    }
                }
            }
        }
        /* f) Tach mang thanh 2 mang con gom mang chua phan tu chan va mang cuhua phan tu le*/
        static void TachMang(int[] a, int n, ref int[] chan, ref int i, ref int[] le, ref int j)
        {
            i = 0; j = 0;
            for(int t=0; t<n; t++)
            {
                if (a[t] % 2 == 0) i++;
                else j++;
            }
            chan = new int[i];
            le=new int[j];

            i = 0; j = 0;
            for (int t = 0; t < n; t++)
            {
                if (a[t] % 2 == 0)
                {
                    chan[i++] = a[t];
                }

                if (a[t] % 2 != 0)
                {
                    le[j++] = a[t];
                }
            }
            if (i != 0) 
            {
                Console.WriteLine("\nDay la mang chan:");
                XuatMang(chan, i);
            }
            
            if (j != 0)
            {
                Console.WriteLine("\nDay la mang le: ");
                XuatMang(le, j);
            }
        }
        static void Main(string[] args)
        {
            int n = 0;
            int[] a = null, chan = null, le = null;
            int i = 0, j = 0;

            NhapMang(ref a, ref n);

            Console.WriteLine("Cac phan tu cua mang:");
            XuatMang(a, n);
            Console.WriteLine("\n");

            Console.WriteLine("GTLN:"+ MaxMang(a, n) + "\n");

            if (TangDan(a, n)) Console.WriteLine("Mang duoc sap xep tang dan!\n");
            else Console.WriteLine("Mang chua duoc xep tang dan!\n");

            XepTangDan(a, n);
            Console.WriteLine("Mang sau khi xep tang dan: ");
            XuatMang(a, n);

            TachMang(a, n, ref chan, ref i, ref le, ref j);
            
        }
    }
}

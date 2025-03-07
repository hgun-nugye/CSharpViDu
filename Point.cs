using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh2
{
    public class Point
    {
        public double X {  get; set; }

        public double Y { get; set; }

        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }
        public void AddPoint()
        {
            Console.WriteLine("Nhap vao x: ");
            X = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao y: ");
            Y = double.Parse(Console.ReadLine());
        }
        public void DisplayPoint()
        {
            Console.WriteLine("({0};{1})", X, Y);
        }
        public void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }
        public double Distance(Point p)
        {
            return Math.Sqrt(Math.Pow(this.X - p.X, 2) + Math.Pow(this.Y - p.Y, 2));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Nhap so luong diem
            int n;
            do
            {
                Console.WriteLine("Nhap vao so luong diem: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1);

            //Nhap danh sach diem
            Point[] listpoint = new Point[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap vao diem thu {0}: ", i + 1);
                listpoint[i] = new Point();
                listpoint[i].AddPoint();
            }

            //In ra man hinh danh sach cac diem
            Console.WriteLine("Danh sach cac diem vua nhap la: ");
            foreach (Point p in listpoint)
            {
                p.DisplayPoint();
            }

            //Tim diem xa goc toa do nhat
            Point GocToaDo = new Point(0, 0);
            double maxDistance = listpoint[0].Distance(GocToaDo);
            Point DiemXaNhat = listpoint[0];
            foreach(Point p in listpoint)
            {
                if(p.Distance(GocToaDo) > maxDistance)
                {
                    maxDistance=p.Distance(GocToaDo);
                    DiemXaNhat = p;
                }
            }
            Console.WriteLine("Diem xa goc toa do nhat la: ");
            DiemXaNhat.DisplayPoint();

            //Tim cap diem gan nhau nhat
            Point p1 = new Point();
            Point p2 = new Point();
            double DiemGanNhau = listpoint[1].Distance(listpoint[0]);
            for(int i=0; i<n -1; i++)
            {
                for(int j=i+1; j<n; j++)
                {
                    if(listpoint[j].Distance(listpoint[i]) < DiemGanNhau)
                    {
                        DiemGanNhau = listpoint[j].Distance(listpoint[i]);
                        p1 = listpoint[i];
                        p2 = listpoint[j];
                    }

                }
            }
            Console.WriteLine("Cap diem gan nhau nhat la: ");
            p1.DisplayPoint();
            p2.DisplayPoint();

        }
    }
}

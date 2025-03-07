using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh2
{
    public class Point
    {
        public double X { get; set; }

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
        
    }
    public class Circle
    {
        public Point c { get; set; } = new Point();
        public double r { get; set; }

        public void NhapHinhTron()
        {
            Console.WriteLine("Nhap vao ban kinh hinh tron: ");
            r = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao diem tam hinh tron: ");
            c.AddPoint();
        }
        public void XuatHinhTron()
        {
            c.DisplayPoint();
        }
        public void Area()
        {
            double S = Math.PI * r * r;
            Console.WriteLine("\nDay la dien tich hinh tron: " + S);
        }
        public void Move(double dx, double dy)
        {
            c.X += dx;
            c.Y += dy;
        }
    }
    class Program
    {
       static void Main(string[] args)
        {            
            Circle cir = new Circle();
            cir.NhapHinhTron();

            Console.WriteLine("\nHinh tron co ban kinh la " + cir.r + " va tam la:");
            cir.XuatHinhTron();

            cir.Area();
            
            Console.WriteLine("\nNhap vao gia tri dx, dy can di chuyen: ");
            double dx= Double.Parse(Console.ReadLine());
            double dy= Double.Parse(Console.ReadLine());
            cir.Move(dx, dy);
            Console.WriteLine("\nHinh tron vua dich chuyen co ban kinh la " + cir.r + " va tam la:");
            cir.XuatHinhTron();

        }
    }
}

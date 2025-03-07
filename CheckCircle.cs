using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh2
{
    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }

    public class Circle
    {
        public Point center;
        public double radius;

        public Circle(Point center, double radius=0)
        {
            this.center = center;
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * this.radius * this.radius;
        }

        public static Circle MaxCircle(List<Circle> circles)
        {
            double max = 0;
            Circle c = null;;
            foreach (Circle cir in circles)
            {
                double area = cir.Area();
                if(area > max)
                {
                    max = area;
                    c = cir;
                }
            }
            return c;
        }

        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) +  Math.Pow(p1.y - p2.y, 2));
        }

        public static bool IntersectionCheck(Circle c1, Circle c2)
        {
            double d=Distance(c1.center, c2.center);
            return (d < c1.radius + c2.radius);
            
        }
    }


    internal class CheckCircle
    {
        public static void Main()
        {
            List <Circle> circles = new List<Circle>();

            double r=-1;
            Console.WriteLine("Ket thuc nhap khi ban kinh = 0\n");
            while (r!=0)
            {
                Console.WriteLine("Nhap vao ban kinh hinh tron: ");
                r = double.Parse(Console.ReadLine());
                if (r == 0) break;

                Console.WriteLine("Nhap vao toa do tam hinh tron: ");
                int x=int.Parse(Console.ReadLine());
                int y=int.Parse(Console.ReadLine());
                
                circles.Add(new Circle(new Point(x,y),r));
            }

            Circle max = Circle.MaxCircle(circles);
            if (max != null)
            {
                Console.WriteLine("\nHinh tron co dien tich lon nhat la ({0}, {1}) co ban kinh {2}\n", max.center.x, max.center.y, max.radius);
            }

            //kiểm tra giao nhau
            int count=0;
            for(int i=0; i<circles.Count-1; i++)
            {
                for(int j=i+1; j<circles.Count; j++)
                {
                    if (Circle.IntersectionCheck(circles[i], circles[j]))
                    {
                        Console.WriteLine("Hai hinh tron giao nhau!");
                        Console.WriteLine("({0}, {1}) co ban kinh {2}", circles[i].center.x, circles[i].center.y, circles[i].radius);
                        Console.WriteLine("({0}, {1}) co ban kinh {2}\n", circles[j].center.x, circles[j].center.y, circles[j].radius);
                        count++;
                    }
                }
            }
            if(count==0) Console.WriteLine("Khong co hinh tron giao nhau!");
        }
    }
}

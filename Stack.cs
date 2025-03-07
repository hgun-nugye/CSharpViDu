using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh2
{
    public class Stack
    {
        public int top;
        public const int MAX  = 100;
        public int[] stack = new int[MAX];
        public Stack()
        {
            top = -1;
        }
       public void PushData(int data)
        {
            if (top >= MAX) Console.WriteLine("Ngan xep day");
            else
            {
                top++;
                stack[top] = data;
            }
       }
        public void Pop(ref int pop)
        {
            if(top!=-1)
            {
                pop = stack[top];
                top--;
            }               
        }
        public void Peek(int pop)
        {
            if (top != -1)
                Console.WriteLine("Phan tu tren cung cua stack la: " + pop);
            else Console.WriteLine("Ngan xep rong");
        }
        public void IsEmpty()
        {
            if (top != -1)
            {
                Console.WriteLine("Ngan xep khong rong");
            }
            else Console.WriteLine("Ngan xep rong");
        }
        public void Print()
        {
            for (int i = top; i > 0; i--)
            {
                Console.Write(stack[i] + "*");
            }
            Console.Write(stack[0]);
        }
        public void PrintBinary()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.Write(stack[i]);
            }
        }
        public void PrintHex()
        {
            string hex = "0123456789ABCDEF";
            for (int i = top; i >= 0; i--)
            {
                Console.Write(hex[stack[i]]);
            }
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack1 = new Stack();
            Console.Write("Nhap vao so n: ");
            int n=int.Parse(Console.ReadLine());
            int n0 = n;

            //tách số nhập vào thành tích các số nguyên tố
            for(int i=2; i<=n; i++)
            {
                while (n % i == 0)
                {
                    stack1.PushData(i);
                    n /= i;
                }                
            }
            Console.Write("So {0} sau khi phan tich thanh cac thua so nguyen to la: ", n0);
            stack1.Print();

            //tách số nhập vào thành số hệ 2
            n = n0;
            Stack stack2=new Stack();
            while(n!=0)
            {
                stack2.PushData(n % 2);
                n /= 2;
            }
            Console.Write("\n\nSo {0} sau khi chuyen sang he 2 la: ", n0);
            stack2.PrintBinary();

            //tách số nhập vào thành số hệ 16
            n = n0;
            Stack stack3 = new Stack();
            while (n != 0)
            {
                stack3.PushData(n % 16);
                n /= 16;
            }
            Console.Write("\n\nSo {0} sau khi chuyen sang he 16 la: ", n0);
            stack3.PrintHex();


        }
    }


}

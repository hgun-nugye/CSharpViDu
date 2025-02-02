using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    internal class Char
    {
        static void Main(string[] args)
        {
            char ch1 = 'a';
            Console.WriteLine(ch1);
            Console.WriteLine(ch1.GetType().ToString());

            char ch2 = (char)65;
            Console.WriteLine(ch2);
            Console.WriteLine(ch2.GetType().ToString());

            //So sánh 2 kí tự
            char ch3 = 'a'; //97
            char ch4 = 'b'; //98
            char ch5 = 'c'; //99
            char ch6 = 'd'; //100
            Console.WriteLine(ch3.CompareTo(ch4));
            Console.WriteLine(ch6.CompareTo(ch5));
            Console.WriteLine(ch6.Equals(ch5));

            /* 
            Một số Char Method
            Char.IsDigit(ch) -> kiểm tra là chữ số
            Char.Is:etter(ch) -> kiểm tra là chữ cái
            Char.IsWhiteSpace(ch) -> kiểm tra là dấu cách
            Char.IsUpper(ch) -> kiểm tra là kí tự in hoa
            Char.IsLower(ch) -> kiểm tra là kí tự thường
            Char.ToLower(ch) -> chuyển kí tự sang thường
            Char.ToUpper(ch) -> chuyển kí tự sang hoa
            */
            Console.WriteLine(Char.IsDigit(ch5));
            Console.WriteLine(Char.IsLetter(ch5));
            Console.WriteLine(Char.IsWhiteSpace(' '));

        }
    }
}

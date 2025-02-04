using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    public class BaiTap
    {
        /* Cho:  
	        str1 = “English = 78 Science = 83 Math = 68 History = 65”
 	        1. tính tổng các số trong chuỗi trên
 	        2. tính trung bình cộng 
        */
        public static void BaiTap1()
        {
            string str1 = "English = 78 Science = 83 Math = 68 History = 65";
            string[] lst = str1.Split(' ');
            string so ="";
            int sum = 0;
            foreach(string s in lst)
            {
                foreach(char c in s)
                {
                    if(Char.IsDigit(c))
                    {
                        so += s + " ";
                        break;
                    }
                }
            }
            so = so.Trim();
            string[] lst2 = so.Split(" ");
            foreach(string num in lst2)
            {
                sum += int.Parse(num);
            }
            float TBC = (float) sum/lst2.Length;
            Console.WriteLine("Gia tri trung binh cong cua cac so trong chuoi la " +TBC);
        }

        /* 
         1. Viết chương trình kiểm tra tính hợp lệ của mật khẩu:
          * mật khẩu hợp lệ khi có ít nhất 6 ký tự chứa ít nhất 1 chữ cái ( chữ cái thường hoặc hoa đều được) 
          * chứa ít nhất 1 chữ số 
          * nhập lại đến khi hợp lệ
         2. Cho người dùng nhập vào mật khẩu để login / so sánh, nếu đúng mở của, sai quá 5 lần khóa đăng nhập, thoát chương trình
        */
        public static void BaiTap2()
        {
            // xử lí phần 1
            bool check = true;

            Console.WriteLine("\nVui long nhap vao mat khau: ");
            string password = Console.ReadLine();

            while (check)
            {
                int demChucai = 0;
                int demChuso = 0;
                foreach (char c in password)
                {

                    if (Char.IsDigit(c))
                    {
                        demChuso++;
                    }
                    if (Char.IsLetter(c))
                    {
                        demChucai++;
                    }
                }
                    if (demChucai*demChuso!=0 && password.Length>=6)
                    {
                        check=false;
                    }
                    else
                    {
                        Console.WriteLine("Vui long nhap lai mat khau: ");
                        password = Console.ReadLine();
                        check = true;
                    }
            }
            Console.WriteLine("Da nhap mat khau thanh cong!");

            //xử lí phần 2

            Console.WriteLine("\nNhap vao mat khau de dang nhap: ");
            string login = Console.ReadLine();
            int demLogin = 0;

            while(true)
            {
                bool ketqua = password.Equals(login);
                if(ketqua)
                {
                    Console.WriteLine("Dang nhap thanh cong");
                    break;
                }
                else
                {
                    demLogin++;
                    if (demLogin < 5)
                    {
                        Console.WriteLine("Nhap lai mat khau de dang nhap, nhap sai {0}/5 lan: ", demLogin);
                        login = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Ban da nhap mat khau sai 5 lan, khoa dang nhap");
                        break;
                    }

                }
            }
        }

        /* Viết chương trình chuyển tin nhắn sang mật mã theo bảng : 	
         #a="abcdefghijklmnopqrstuvwxyz"   
	     #b="zxcvbnmasdfghjklqwertyuiop“  */
        public static void BaiTap3()
        {
            string de = "abcdefghijklmnopqrstuvwxyz";
            string en = "zxcvbnmasdfghjklqwertyuiop";

            Console.WriteLine("\nNhap vao noi dung tin nhan de ma hoa: ");
            string message = Console.ReadLine();
            string encode_message ="";
            for (int i = 0; i < message.Length; i++)
            {
                if(!char.IsLower(message[i]))
                {
                    encode_message += message[i];
                }
                else
                {
                    for (int j = 0; j < de.Length; j++)
                    {
                        if (message[i].CompareTo(de[j]) == 0)
                        {
                            encode_message += en[j];
                        }
                    }
                }
            }
            Console.WriteLine("Noi dung tin nhan sau khi duoc ma hoa la: " + encode_message);
        }
        /* Cho chuỗi : 
	        a= “
	        tôi chăm học
	        tôi chịu khó
	        tôi đẹp zai
	        “
	        đếm từ "toi" trong string a trên
        */
        public static void BaiTap4()
        {
            string a = @"
                        toi cham hoc 
                        toi chiu kho 
                        toi dep zai
                        ";
            string check = "toi";
            int dem = 0;
            string[] tach = a.Split(' ');
            foreach(string s in tach)
            {
                if (s.Contains(check))
                {
                    dem++;
                }
            }
            Console.WriteLine("\nCo " + dem + " tu toi trong chuoi.");
        }
        /* Viết chương trình tách số và chữ từ chuỗi nhập vào thành 2 chuỗi : 	
             * ví dụ nhập vào : abc123 sẽ tách và in ra thành 2 chuỗi abc và 123
        */
        public static void BaiTap5()
        {
            string output_so="";
            string output_chu="";
            Console.WriteLine("\nNhap vao chuoi: ");
            string input = Console.ReadLine();

            for (int i=0; i<input.Length; i++)
            {
                int j = i;
                if (char.IsDigit(input[i]))
                {
                    output_so += input[i];                     
                }                
                else if (char.IsLetter(input[i]))
                {
                    output_chu += input[i];
                }
                if (i < input.Length - 1 && char.IsWhiteSpace(input[i]))
                {
                    if (char.IsDigit(input[i + 1]))
                    {
                        output_so += " ";
                    }
                    else if (char.IsLetter(input[i + 1]))
                    {
                        output_chu += " ";
                    }
                }
            }
            Console.WriteLine("Chuoi sau khi da tach chu cai va so la: ");
            Console.WriteLine(output_chu);
            Console.WriteLine(output_so);
        }
        static void Main(string[] args)
        {
            BaiTap1();
            BaiTap2();
            BaiTap3();
            BaiTap4();
            BaiTap5();
        }
    }
}

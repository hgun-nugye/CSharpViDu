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
            int demSo = 0;
            int sum = 0;
            for(int i=0; i<str1.Length; i++)
            {
                if (Char.IsDigit(str1[i]))
                {
                    demSo++;
                    sum += str1[i];
                }
            }
            float TBC = (float) sum/demSo;
            Console.WriteLine("Gia tri trung binh cong cua cac so trong chuoi la " +TBC);
        }

        /* 1. Viết chương trình kiểm tra tính hợp lệ của mật khẩu: aaaaaAAAAAA1
          *  mật khẩu hợp lệ khi có ít nhất 6 ký tự chứa ít nhất 1 chữ cái ( chữ cái thường hoặc hoa đều được) 
          *chứa ít nhất 1 chữ số 
         2. Cho người dùng nhập vào mật khẩu để login / so sánh, nếu đúng mở của, sai quá 5 lần khóa đăng nhập, thoát chương trình
        */
        public static void BaiTap2_1()
        {
            string password = "aaaaaAAAAAA1";
            int chucai = 0;
            int chuso = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password.Length < 6)
                {
                    break;
                }
                else
                {
                    if (Char.IsDigit(password[i]))
                    {
                        chuso++;
                    }
                    else if (Char.IsLetter(password[i]))
                    {
                        chucai++;
                    }
                }
            }
            if (chucai >= 1 && chuso >= 1) Console.WriteLine("\nMat khau hop le.");
            else Console.WriteLine("\nMat khau khong hop le.");
        }
        public static void BaiTap2_2(out string matkhau)
        {
            string password = "DayLaMatKhau@123";
            matkhau ="";
            int count = 0;
            do
            {
                if (count == 5)
                {
                Console.WriteLine("Qua so lan nhap mat khau, vui long nhap lai sau!");
                break;
                }

                Console.WriteLine("\nNhap vao mat khau de dang nhap: ");
                matkhau = Console.ReadLine();
                count++;

                if(matkhau.CompareTo(password) == 0)
                    Console.WriteLine("Da nhap mat khau thanh cong");
            } while (matkhau.CompareTo(password) != 0);

        }
        /* Viết chương trình chuyển tin nhắn sang mật mã theo bảng : 	
         #a="abcdefghijklmnopqrstuvwxyz"   
	     #b="zxcvbnmasdfghjklqwertyuiop“  */
        public static void BaiTap3(out string message)
        {
            string de = "abcdefghijklmnopqrstuvwxyz";
            string en = "zxcvbnmasdfghjklqwertyuiop";
            Console.WriteLine("\nNhap vao noi dung tin nhan de ma hoa: ");
            message = Console.ReadLine();
            string en_message = "";
            for (int i = 0; i < message.Length; i++)
            {
                if(!char.IsLower(message[i]))
                {
                    en_message += message[i];
                }
                else
                {
                    for (int j = 0; j < de.Length; j++)
                    {
                        if (message[i].CompareTo(de[j]) == 0)
                        {
                            en_message += en[j];
                        }
                    }
                }
            }
            Console.WriteLine("Noi dung tin nhan sau khi duoc ma hoa la: " + en_message);
        }
        /* Cho chuỗi : 
	        a= “
	        tôi chăm học
	        tôi chịu khó
	        tôi đẹp zai
	        “
	        đếm từ tôi trong string a trên
        */
        public static void BaiTap4()
        {
            string a = "toi cham hoc toi chiu kho toi dep zai";
            string check = "toi";
            int dem = 0;
            string[] tach = a.Split(' ');
            for (int i = 0; i < tach.Length; i++)
            {
                if (tach[i].Contains(check))
                {
                    dem++;
                }
            }
            Console.WriteLine("\nCo " + dem + " tu toi trong chuoi.");
        }
        /* Viết chương trình tách số và chữ từ chuỗi nhập vào thành 2 chuỗi : 	
             * ví dụ nhập vào : abc123 sẽ tách và in ra thành 2 chuỗi abc và 123
        */
        public static void BaiTap5(out string input)
        {
            string output_so="";
            string output_chu="";
            Console.WriteLine("\nNhap vao chuoi: ");
            input = Console.ReadLine();

            foreach (char i in input)
            {
                if (char.IsDigit(i))
                {
                    output_so += i;
                }
                else if (char.IsLetter(i))
                {
                    output_chu += i;
                }
            }
            Console.WriteLine("Chuoi sau khi da tach chu cai va so la: ");
            Console.WriteLine(output_chu);
            Console.WriteLine(output_so);
        }
        static void Main(string[] args)
        {
            BaiTap1();
            BaiTap2_1();
            string matkhau;
            BaiTap2_2(out matkhau);
            string message;
            BaiTap3(out message);
            BaiTap4();
            string input;
            BaiTap5(out input);
        }
    }
}

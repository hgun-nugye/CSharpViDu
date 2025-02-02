using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu
{
    internal class String
    {
        static void Main(string[] args)
        {
            //khai bao chuoi
            string chuoi = "Dang code C#";
            Console.WriteLine("Chuoi vua nhap la: " + chuoi);

            //khai bao nguyen van voi @
            string nguyenvan = @"Day la khai bao nguyen van. D:\CSharp";
            Console.WriteLine(nguyenvan);

            //chuyển đổi sang chuỗi
            int a = 1234;

            Console.WriteLine("\nSo {0} da chuyen sang chuoi la {1} {2}" ,a, a.ToString(), a.ToString().GetType().ToString()); //cach 1
            Console.WriteLine("So {0} da chuyen sang chuoi la {1} {2}", a, Convert.ToString(a), Convert.ToString(a).GetType().ToString()); //cach 2
            Console.WriteLine("So {0} da chuyen sang chuoi la {1} {2}", a,  a + "", (a + "").GetType().ToString()); //cach 3

            //tách kí tự lẻ từ chuỗi cho vào mảng
            string chuoitach = "XinChao";
            char[] lst=chuoitach.ToCharArray();
            Console.WriteLine(lst.GetType().ToString());

            //xác định chiều dài chuỗi
            string chuoidai = "Test Haha";
            int dai = chuoidai.Length;
            Console.WriteLine("\nDo dai chuoi la: "+dai);
            Console.WriteLine("Ki tu thu nhat cua chuoi la " + chuoidai[0]);

            //Kiểm tra số kí tự hoa, thường
            string chuoitest = "Day la chuoi dung de test co so 1 2 3 va cac ki tu.";
            int length=chuoitest.Length;
            int hoa = 0, thuong = 0, so=0, space=0;
            for(int i=0; i<length; i++)
            {
                if (Char.IsUpper(chuoitest[i]))
                {
                    hoa++;
                }
                else if (Char.IsLower(chuoitest[i]))
                {
                    thuong++;
                }
                else if (Char.IsDigit(chuoitest[i]))
                {
                    so++;
                }
                else if (Char.IsWhiteSpace(chuoitest[i]))
                {
                    space++;
                }

            }
            Console.WriteLine("\nSo ki tu hoa trong chuoi \"{0}\" la {1}.", chuoitest, hoa);
            Console.WriteLine("So ki tu thuong trong chuoi \"{0}\" la {1}.", chuoitest, thuong);
            Console.WriteLine("So ki tu khoang trang trong chuoi \"{0}\" la {1}.", chuoitest, space);
            Console.WriteLine("So ki tu chu so trong chuoi \"{0}\" la {1}.", chuoitest, so);

            //So sánh chuỗi
            string chuoi1 = "123a";
            string chuoi2 = "123z";
            int sosanh=(chuoi1.CompareTo(chuoi2));
            Console.WriteLine(sosanh);
            /*So sánh chuỗi
             Nếu chuỗi bằng nhau thì trả về 0
            Nếu chuỗi lớn hơn thì trả về 1
            Nếu chuỗi nhỏ hơn thì trả về -1*/

            //Kiểm tra chuỗi con
            string chuoicha = "abcdef";
            string chuoicon = "abe";
            bool con = chuoicha.Contains(chuoicon);
            Console.WriteLine(con);
            //Chỉ trả về True thì chuỗi con theo thứ tự các kí tự trong chuỗi cha

            //Hàm Copyto
            string chuoicopy = "123456";
            char[] list = new char[6]; //tạo ra mảng có độ dài la 6
            list[0]='a';
            list[1] = 'b';
            Console.WriteLine(list);
            chuoicopy.CopyTo(1,list,2,4); 
            //1 là vị trí bắt đầu copy, list là đích gắn, 2 là vị trí gắn, 4 là số kí tự được lấy gắn
            Console.WriteLine(list);

            //Hàm bool EndsWith
            string link = "Conduongmua.mp4";
            bool ktra = link.EndsWith("mp4");
            Console.WriteLine(ktra);

            //Gán chuỗi theo string.Format
            string ganchuoi;
            int value = 16;
            ganchuoi=string.Format("\nCan bac hai cua {0} la {1}",a,Math.Sqrt(value));
            Console.WriteLine(ganchuoi);
            Console.WriteLine("Can bac hai cua {0} la {1}", a, Math.Sqrt(value));

            //Hàm Equals: giống hệt nhau trả True, khác nhau trả False
            string chuoitest1 = "Day la chuoi thu nhat";
            string chuoitest2 = "Day la chuoi thu hai";
            bool check = chuoitest1.Equals(chuoitest2);
            Console.WriteLine(check);

            //Hàm string.Insert
            string chuoigoc1 = "\nBun ";
            string chuoigoc2 = "rieu";
            chuoigoc1 = chuoigoc1.Insert(5, chuoigoc2);
            //5 là vị trí bắt đầu chèn chuỗi chuoigoc2 vào sau chuoigoc1
            //Nếu vị trí chèn là 1 thì chuỗi mới sẽ là "\nrieuBun ", tức là không bị mất kí tự 
            Console.WriteLine(chuoigoc1);
        }
    }
}

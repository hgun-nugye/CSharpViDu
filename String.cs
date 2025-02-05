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
            //1. khai báo chuỗi
            string chuoi = "Dang code C#";
            Console.WriteLine("Chuoi vua nhap la: " + chuoi);

            //2. khai báo nguyên văn với @
            string nguyenvan = @"Day la khai bao nguyen van. D:\CSharp";
            Console.WriteLine(nguyenvan);

            //3. chuyển đổi sang chuỗi
            int a = 1234;

            Console.WriteLine("\nSo {0} da chuyen sang chuoi la {1} {2}" ,a, a.ToString(), a.ToString().GetType().ToString()); //cach 1
            Console.WriteLine("So {0} da chuyen sang chuoi la {1} {2}", a, Convert.ToString(a), Convert.ToString(a).GetType().ToString()); //cach 2
            Console.WriteLine("So {0} da chuyen sang chuoi la {1} {2}", a,  a + "", (a + "").GetType().ToString()); //cach 3

            //4. tách kí tự lẻ từ chuỗi cho vào mảng
            string chuoitach = "XinChao";
            char[] lst=chuoitach.ToCharArray();
            Console.WriteLine(lst.GetType().ToString());

            //5. xác định chiều dài chuỗi
            string chuoidai = "Test Haha";
            int dai = chuoidai.Length;
            Console.WriteLine("\nDo dai chuoi la: "+dai);
            Console.WriteLine("Ki tu thu nhat cua chuoi la " + chuoidai[0]);

            //6. Kiểm tra số kí tự hoa, thường
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

            //7. So sánh chuỗi
            string chuoi1 = "123a";
            string chuoi2 = "123z";
            int sosanh=(chuoi1.CompareTo(chuoi2));
            Console.WriteLine(sosanh);
            /*So sánh chuỗi
             Nếu chuỗi bằng nhau thì trả về 0
            Nếu chuỗi lớn hơn thì trả về 1
            Nếu chuỗi nhỏ hơn thì trả về -1*/

            //8. Kiểm tra chuỗi con
            string chuoicha = "abcdef";
            string chuoicon = "abe";
            bool con = chuoicha.Contains(chuoicon);
            Console.WriteLine(con);
            //Chỉ trả về True thì chuỗi con theo thứ tự các kí tự trong chuỗi cha

            //9. Hàm CopyTo
            string chuoicopy = "123456";
            char[] list = new char[6]; //tạo ra mảng có độ dài la 6
            list[0]='a';
            list[1] = 'b';
            Console.WriteLine(list);
            chuoicopy.CopyTo(1,list,2,4); 
            //1 là vị trí bắt đầu copy, list là đích gắn, 2 là vị trí gắn, 4 là số kí tự được lấy gắn
            Console.WriteLine(list);

            //10. Hàm bool EndsWith
            string link = "Conduongmua.mp4";
            bool ktra = link.EndsWith("mp4");
            Console.WriteLine(ktra);

            //11. Gán chuỗi theo string.Format
            string ganchuoi;
            int value = 16;
            ganchuoi=string.Format("\nCan bac hai cua {0} la {1}",a,Math.Sqrt(value));
            Console.WriteLine(ganchuoi);
            Console.WriteLine("Can bac hai cua {0} la {1}", a, Math.Sqrt(value));

            //12. Hàm Equals: giống hệt nhau trả True, khác nhau trả False
            string chuoitest1 = "Day la chuoi thu nhat";
            string chuoitest2 = "Day la chuoi thu hai";
            bool check = chuoitest1.Equals(chuoitest2);
            Console.WriteLine(check);

            //13. Hàm string.Insert
            string chuoigoc1 = "\nBun ";
            string chuoigoc2 = "rieuu";
            chuoigoc1 = chuoigoc1.Insert(5, chuoigoc2);
            //5 là vị trí bắt đầu chèn chuỗi chuoigoc2 vào sau chuoigoc1
            //Nếu vị trí chèn là 1 thì chuỗi mới sẽ là "\nrieuBun ", tức là không bị mất kí tự 
            Console.WriteLine(chuoigoc1);

            //14. IndexOf(ch) -> trả về vị trí xuất hiện đầu tiên của kí tự ch
            int index1 = chuoigoc1.IndexOf('u');
            Console.WriteLine(index1);

            //15. LastIndexOf(ch) -> trả về vị trí xuất hiện cuối cùng của kí tự ch
            int index2 = chuoigoc2.LastIndexOf('u');
            Console.WriteLine(index2);

            //16. Remove(index, count) -> index là vị trí bắt đầu xóa, count là số lượng kí tự muốn xóa
            chuoigoc1 = chuoigoc1.Remove(4, 1);
            Console.WriteLine(chuoigoc1);

            //17. Replace("str old", "str new") -> str old là chuỗi cũ muốn đổi, str new là chuỗi mới muốn thay thế
            chuoigoc2 = chuoigoc2.Replace("uu", "u");
            Console.WriteLine(chuoigoc2);

            //18. bool StartsWith("str") -> kiểm tra xem chuỗi có bắt đầu bằng chuỗi str không
            bool kiemtra = chuoigoc1.StartsWith("\n");
            Console.WriteLine(kiemtra);

            //19. Substring(start inex, count) -> tách chuỗi con từ chuỗi cha
            string momstr = "Hom nay la thu bay";
            string sonstr;
            sonstr = momstr.Substring(11, 7);
            Console.WriteLine(momstr);
            Console.WriteLine(sonstr);

            //20. ToLower(); ToUpper() -> chuyển chuỗi sang chuỗi thường/chuỗi hoa
            Console.WriteLine(chuoigoc1.ToLower());
            Console.WriteLine(chuoigoc2.ToUpper());

            //21. Trim() -> xóa toàn bộ khoảng trắng ở đầu và cuối chuỗi
            string chuoitrang = "    \nYeu   la tha    thu    ";
            Console.WriteLine(chuoitrang.Trim());
            //Tương tự có TrimEnd() - xóa đầu và TrimStart() - xóa cuối

            //22. Split(char) -> tách chuỗi thông qua kí tự char
            string chuoitach2 = "onw,two,three";
            Console.WriteLine( chuoitach2);
            string[] tachchuoi = chuoitach2.Split(',');
            Console.WriteLine(tachchuoi[0]);
            Console.WriteLine(tachchuoi[1]);
            Console.WriteLine(tachchuoi[tachchuoi.Length-1]);

            //23. string.Join(char) -> nối chuỗi có thêm dấu char
            string noichuoi = string.Join('.',tachchuoi);
            Console.WriteLine(noichuoi);
        }
    }
}

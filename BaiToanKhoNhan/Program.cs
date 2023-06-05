using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiToanKhoNhan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Moi ban nhap ten: ");
            string name = Console.ReadLine();
            Console.WriteLine("Moi ban nhap msv: ");
            string msv = Console.ReadLine() + "@fpt.edu.vn";
            List<string> lstStr = name.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList(); // Cắt theo kí tự nào đấy
            // .Trim dung de cat bo ki tu khoang trang o dau va cuoi
            // VD: Nguyen Van Duc Anh
            string email = lstStr[lstStr.Count - 1];
            // email = "Anh"
            for (int i = 0; i < lstStr.Count - 1; i++)
            {
                // Lay chu cai dau tien cua thanh phan trong ten
                email += lstStr[i].Substring(0, 1);
            }
            // email = anhnvd
            email = RemoveUnicode(email.ToLower());
            Console.WriteLine((email + msv).ToLower());

        }
        public static string RemoveUnicode(string str)
        {
            List<string> listUnicode = new List<string>() { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ" };
            List<string> listNonUnicode = new List<string>()
            {
                "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y"};
            for (int i = 0; i < listUnicode.Count; i++)
            {
                str = str.Replace(listUnicode[i], listNonUnicode[i]);
            }
            return str;
        }
    }
}

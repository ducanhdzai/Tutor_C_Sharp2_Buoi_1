using System;
using System.Text;
using static Event.Children;

namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Children children = new Children();
            children.DangKiSuKien += InRaManHinh;// Đăng kí sự kiện sẽ xảy ra khi Event được kích hoạt
            children.ActiveEvent(); // Kích hoạt Event
            Console.ReadKey();
        }
        public static void InRaManHinh(object obj, CustomeEventArgs customeEventArgs)
        {
            Console.WriteLine(customeEventArgs.Message);
        }
    }
}

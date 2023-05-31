using System;

namespace Delegate_Event
{
    internal class Program
    {
        public delegate void DelegateCustom(string messsage); // Đang tạo ra 1 kiểu dữ liệu dạng delegate có tên là DelegateCustom
        static void Main(string[] args)
        {
            // Delegate là 1 kiểu dữ liệu tham chiếu
            // nó có thể gọi đến một hàm như 1 kiểu dữ liệu
            // Cùng chữ kí thì mới có thể đăng kí sự kiện 
            // Sẽ là kiểu dữ liệu truyền vào, kiểu dữ liệu trả về là chữ kí 
            //DelegateCustom dangKiEvent = null; // Kiến thức này đã được tiếp thu
            DelegateCustom dangKiEvent = TangQua;
            NhanQua("Doi giay bac ti", dangKiEvent);
            Console.ReadKey();
        }
        public static void TangQua(string messsage) => Console.WriteLine("Qua da tang" + messsage); //Viết hàm như bình thường
        // {} been trong sẽ là 1 khối lệnh 
        public static void NhanQua(string messsage, DelegateCustom tangqua)
        {
            Console.WriteLine("--------");
            Console.WriteLine("Qua" + messsage.ToUpper());
            tangqua(messsage);
        }
    }
}

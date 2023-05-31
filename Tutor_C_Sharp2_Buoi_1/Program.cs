using System;
using System.Text;

namespace Tutor_C_Sharp2_Buoi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Có những loại hàm nào?
            // Hàm trả về
            // Hàm không trả về
            // Hàm có tham số
            //1. Hàm dễ dùng nhất là 
            //- 
            // Có thể gán vào biến các hàm trả về để sử dụng
            Console.WriteLine(HamEasyTop4("cu xuan hop"));// => CU XUAN HOP 
            Console.ReadKey();
        }
        #region Hàm không trả về và không có tham số
        public static void HamEasy()
        {
            // Khi mà không truyền vào hay trả về gì cả thì sẽ chỉ thực hiện những hành động ở bên trong hàm đấy thôi
            Console.WriteLine("Hello, 500 anh em!");
            Console.WriteLine("Hi, 500 anh em!");
            Console.WriteLine("Xin chào, 500 anh em!");
            Console.WriteLine("Ní hảo, 500 anh em!");
            Console.WriteLine("Konnichiwa, 500 anh em!");
        }
        #endregion
        #region Hàm không trả về có tham số
        public static void HamEasyTop2(string message)
        {
            // Khi mà truyền dữ liệu vào thì ta có thể sử dụng dữ liệu đó như bình thường
            // Và tham số được truyền vào sẽ chỉ có tác dụng ở trong hàm
            Console.WriteLine("Hello, " + message);
            Console.WriteLine("Hi, " + message);
            Console.WriteLine("Xin chào, " + message);
            Console.WriteLine("Ní hảo, " + message);
            Console.WriteLine("Konnichiwa, " + message);
        }
        #endregion
        #region Hàm trả về không có tham số
        public static string HamEasyTop3()
        {
            // Khi mà chỉ định kiểu trả về thì ta bắt buộc phải return kiểu dữ liệu đó ở trong hàm
            //Có thể làm bất cứ cái gì miễn là cuối cùng ra được kiểu dữ liệu đúng
            return "Xin chao";
        }
        #endregion
        #region Hàm  trả về có tham số
        public static string HamEasyTop4(string message)
        {
            // Khi mà chỉ định kiểu trả về thì ta bắt buộc phải return kiểu dữ liệu đó ở trong hàm và phải có tham số truyền vào cho nó
            //Có thể làm bất cứ cái gì miễn là cuối cùng ra được kiểu dữ liệu đúng
            return message.ToUpper();
        }
        #endregion
    }
}

using System;

namespace Event
{
    internal class Children
    {
        public delegate void DangKiSuKien(object obj, CustomeEventArgs eventArgs);
        public DangKiSuKien dangKiSuKien;
        public void ActiveEvent()
        {
            CustomeEventArgs e = new CustomeEventArgs() { Message = "Đã gọi đến" };// Sẽ lưu trữ giá trị vào Event
            dangKiSuKien?.Invoke(null, e); // Dấu hỏi chấm là để check null, thực hiện lần lượt những sự kiện đã được đăng kí.
        }
        public class CustomeEventArgs : EventArgs //Tạo ra 1 sự kiện
        {
            public string Message { get; set; }
        }
    }
}

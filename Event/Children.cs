using System;

namespace Event
{
    internal class Children
    {
        public event EventHandler<CustomeEventArgs> DangKiSuKien;
        public void ActiveEvent()
        {
            CustomeEventArgs e = new CustomeEventArgs() { Message = "Đã gọi đến" };// Sẽ lưu trữ giá trị vào Event
            DangKiSuKien?.Invoke(null, e); // Dấu hỏi chấm là để check null, thực hiện lần lượt những sự kiện đã được đăng kí.
        }
        public class CustomeEventArgs : EventArgs //Tạo ra 1 sự kiện
        {
            public string Message { get; set; }
        }
    }
}

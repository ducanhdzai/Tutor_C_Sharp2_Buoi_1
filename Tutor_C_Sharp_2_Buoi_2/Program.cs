using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutor_C_Sharp_2_Buoi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Bai 1");
            //List<int> lstInt = new List<int>() { 7, 11, 21, 31, 45, 51, 87 };
            //List<string> lstString = new List<string>() { "Hai", "Ba", "Bon", "Nam" };
            //IList<string> lstEmpty = new List<string>();
            IList<Student> lstStudent = new List<Student>()
            {
                new Student() {StudentId=1,StudentName="Duc Anh",StandardID = 2}, //0
                new Student() {StudentId=2,StudentName="Hai Occho",StandardID = 1},//1
                new Student() {StudentId=3,StudentName="Trong",StandardID = 3},//2
                new Student() {StudentId=4,StudentName="Phong",StandardID = 2},//3
                new Student() {StudentId=5,StudentName="Phong",StandardID = 4},//4
            };
            IList<Standard> lstStandard = new List<Standard>() {
                new Standard(){ StandardID= 1, StandardName="Standard 1"},
                new Standard(){ StandardID= 2, StandardName="Standard 2"},
                new Standard(){ StandardID= 3, StandardName="Standard 3"}

            };
            var queryJoin = (from student in lstStudent
                             join standard in lstStandard
                             on student.StandardID equals standard.StandardID
                             select new
                             {
                                 student.StudentName,
                                 standard.StandardName
                             }).ToList();
            var methodJoin = lstStudent.Join(lstStandard,
                student => student.StandardID,
                standard => standard.StandardID,
                (student, standard) => new
                {
                    student, // Đang là đặt tên biến để select ra 
                    standard
                });
            var methodGroupJoin = lstStandard.GroupJoin(lstStudent,
              standard => standard.StandardID,
              student => student.StandardID,
              (standard, student) => new
              {
                  standard, // Đang là đặt tên biến để select ra 
                  student
              });
            //foreach (var item in methodJoin)
            //{
            //    Console.WriteLine(item.student.StudentName + " - " + item.standard.StandardName);
            //}
            foreach (var item in methodGroupJoin)
            {
                Console.WriteLine(item.standard.StandardName);
                foreach (var itemChild in item.student)
                {
                    Console.WriteLine(itemChild.StudentName);
                }
            }
            //foreach (var student in queryJoin)
            //{
            //    Console.WriteLine(student.StudentName + " - " + student.StandardName);
            //}
            //// First, FirstOrDefault, Last, LastOrDefault,Single,SingleOrDefault,DefaultIfEmpty,ElementAt,ElementAtOrDerFault được gọi là LinQ Elements Operators
            //Console.ForegroundColor = ConsoleColor.Green;
            ////   var check = lstStudent.ElementAt(1);
            //var check = lstInt.LastOrDefault(c => c > 200) == 0 ? "Không có phần tử nào mô" : lstInt.LastOrDefault(c => c > 200).ToString(); // Toán tử 3 ngôi
            //Console.WriteLine("Phần tử cuối cùng ở trong list mà > 200 là: " + check);
            //// Nếu mà không thấy khứa nào thì có báo là không tìm thấy khum ??? Giờ mà ko phải là 0 với cả Null mà là C#2 Vip pro thì sao
            //// Sẽ ra bằng 0 bởi vì Default là trả ra kết quả mặc định của kiểu dữ liệu đấy
            //// VD: int = 0, string = null, bool = false,....
            //lstString.ForEach(text =>
            //{
            //    if (text.StartsWith("H"))
            //    {
            //        Console.WriteLine(text);
            //    }
            //});
            //Console.WriteLine("Tổng các giá trị tại index lẻ là: " + lstInt.Where(c => lstInt.IndexOf(c) % 2 == 1).Sum());
            Console.ReadKey();
        }
        public class Student
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public int StandardID { get; set; }
        }
        public class Standard
        {
            public int StandardID { get; set; }
            public string StandardName { get; set; }
        }
    }
}

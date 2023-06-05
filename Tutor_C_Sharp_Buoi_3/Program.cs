using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Tutor_C_Sharp_Buoi_3
{
    internal class Program
    {
        static FileStream _fs;
        static BinaryFormatter _bf = new BinaryFormatter();
        static List<Student> lstStudent;
        static void Main(string[] args)
        {
            // Khoi tao doi tuong de tuan tu hoa du lieu
            // LINQ : LANGUE Intergrated Query -> Ngon ngu truy van
            // LINQ dùng để sắp xếp,...
            // Đi thi thì sẽ là dạng sắp xếp, where, 1 số thao tác đến chuỗi
            string filePath = @"C:\Users\ADMIN\Desktop\C#2_Tutor\Tutor_C_Sharp2_Buoi_1\Tutor_C_Sharp_Buoi_3\data.bin";
            lstStudent = new List<Student>()
            {
                new Student{ Id= Guid.NewGuid(), Name = "Hai Occho"}, // GUID là 1 đoạn string được random mục đích thường là để sử dụng làm khóa chính bởi vì nó rất rất khó để bị trùng lặp,.
                new Student{ Id= Guid.NewGuid(), Name = "Duc Anh"},
                new Student{ Id= Guid.NewGuid(), Name = "DinhQuynhTrang"},
                new Student{ Id= Guid.NewGuid(), Name = "Mai Nguyen Long Vu"},
                new Student{ Id= Guid.NewGuid(), Name = "Truong Van Hoang"},
                new Student{ Id= Guid.NewGuid(), Name = "Dang Xuan Phong"},
            };
            try
            {
                SaveFile(filePath);
                ReadFile(filePath);
            }
            catch (System.Exception e)
            {

                throw e;
            }
            Console.ReadKey();
        }
        public static void SaveFile(string filePath)
        {
            Console.WriteLine("Save File");
            // Kiểm tra xem file đã tồn tại hay chưa
            if (Directory.Exists(filePath))
            {
                _fs = new FileStream(filePath, FileMode.Create);// Tao ra file 
                _bf.Serialize(_fs, lstStudent);
                _fs.Close();// Đóng lại để còn làm việc khác
            };
        }
        public static void ReadFile(string filePath)
        {
            Console.WriteLine("Read File");
            if (!Directory.Exists(filePath))
            {
                _fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);// Tao ra file
                var data = _bf.Deserialize(_fs) as List<Student>; // Ép kiểu dữ liệu
                _fs.Close();// Đóng lại để còn làm việc khác
                foreach (var item in data)
                {
                    Console.WriteLine("ID: " + item.Id);
                    Console.WriteLine("Name: " + item.Name);
                }
            }
            else
            {
                Console.WriteLine("Du lieu khong co");
            }
        }
        [Serializable] // Cần phải đánh dấu là tuần tự hóa
        public class Student
        {
            public Guid Id { get; set; }
            public string Name { get; set; }

        }
    }
}

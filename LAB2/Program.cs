using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LAB2;

namespace LAB2
{
    class Program
    {
        public static List<Student> students = new List<Student>()
        {
            new Student(){ studentId = "1", studentName = "Nguyen Van A", age = 20, phone = "0333912821", address = "Hà Nội" },
            new Student(){ studentId = "2", studentName = "Nguyen Van B", age = 20, phone = "0333912822", address = "Phú Thọ" },
            new Student(){ studentId = "3", studentName = "Nguyen Van C", age = 20, phone = "0333912823", address = "Thái Bình" },
            new Student(){ studentId = "4", studentName = "Nguyen Van D", age = 20, phone = "0333912824", address = "Hưng Yên" },
            new Student(){ studentId = "5", studentName = "Nguyen Van E", age = 20, phone = "0333912825", address = "Hà Nội" },
        };

        public static bool addStudent(Student student)
        {
            try
            {
                // Kiểm tra nếu đã tồn tại sinh viên theo studentId
                bool isExist = students.Any(x => x.studentId == student.studentId);
                if (isExist)
                    throw new Exception("Sinh viên đã tồn tại!");
                students.Add(student);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool editStudent(Student student)
        {
            foreach (var item in students)
            {
                if (item.studentId == student.studentId)
                {
                    item.studentName = student.studentName;
                    item.age = student.age;
                    item.address = student.address;
                    item.phone = student.phone;
                    return true;
                }
            }
            return false;
        }

        public static bool deleteStudent(Student student)
        {
            try
            {
                students.Remove(student);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void getStudents()
        {
            Console.WriteLine("ID\tNAME\t\tAGE\tPHONE\t\tADDRESS");
            foreach (var item in students)
            {
                Console.WriteLine($"{item.studentId}\t{item.studentName}\t{item.age}\t{item.phone}\t{item.address}");
            }
        }

        public static void alert(bool isSuccess, string action)
        {
            string message = isSuccess ? $"{action} thành công!" : $"{action} thất bại!";
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        public static void getMenu()
        {
            int n;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------Quản lý sinh viên----------------------");
                getStudents();
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("\t1. Thêm sinh viên");
                Console.WriteLine("\t2. Sửa sinh viên");
                Console.WriteLine("\t3. Xoá sinh viên");
                Console.WriteLine("\t4. Thoát");

                do
                {
                    Console.Write("- Mời bạn chọn chức năng: ");
                    n = int.Parse(Console.ReadLine());
                } while (n < 1 || n > 4);

                switch (n)
                {
                    case 1:
                        {
                            Student student = new Student();
                            Console.Write("- Nhập ID: ");
                            student.studentId = Console.ReadLine();
                            Console.Write("- Nhập họ tên: ");
                            student.studentName = Console.ReadLine();
                            Console.Write("- Nhập tuổi: ");
                            // Chuyển đổi từ chuỗi sang số nguyên cho tuổi
                            student.age = int.Parse(Console.ReadLine());
                            Console.Write("- Nhập địa chỉ: ");
                            student.address = Console.ReadLine();
                            Console.Write("- Nhập số điện thoại: ");
                            student.phone = Console.ReadLine();
                            alert(addStudent(student), "Thêm");
                        }
                        break;
                    case 2:
                        {
                            Console.Write("- Chọn ID sinh viên muốn sửa: ");
                            string id = Console.ReadLine();
                            Student student = students.FirstOrDefault(x => x.studentId == id);
                            if (student == null)
                            {
                                Console.WriteLine("Sinh viên không tồn tại!");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
                                break;
                            }
                            Console.Write("- Nhập họ tên: ");
                            student.studentName = Console.ReadLine();
                            Console.Write("- Nhập tuổi: ");
                            student.age = int.Parse(Console.ReadLine());
                            Console.Write("- Nhập địa chỉ: ");
                            student.address = Console.ReadLine();
                            Console.Write("- Nhập số điện thoại: ");
                            student.phone = Console.ReadLine();
                            alert(editStudent(student), "Sửa");
                        }
                        break;
                    case 3:
                        {
                            Console.Write("- Chọn ID sinh viên muốn xoá: ");
                            string id = Console.ReadLine();
                            Student student = students.FirstOrDefault(x => x.studentId == id);
                            if (student == null)
                            {
                                Console.WriteLine("Sinh viên không tồn tại!");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadLine();
                                break;
                            }
                            alert(deleteStudent(student), "Xoá");
                        }
                        break;
                    case 4:
                        {
                            // Thoát chương trình
                        }
                        break;
                }
            } while (n != 4);
        }

        static void Main(string[] args)
        {
            // Config Console Output hỗ trợ tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;
            getMenu();
        }
    }
}

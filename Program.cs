using EFProject.Data;
using EFProject.Models;

namespace EFProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDBContext();

            // إضافة طالب جديد - Add Student
            //Console.WriteLine("Add Student");
            //var newStudent = new Student { Name = "فاطمة راشد", Age = 24 };
            //db.Students.Add(newStudent);
            //db.SaveChanges();
            //Console.WriteLine("Student ID= " + newStudent.Id + ", Student Name= " + newStudent.Name + ", Student Age= " + newStudent.Age);

            // تحديث بيانات طالب - Update Student
            //Console.WriteLine("Update Student");
            //var student = db.Students.FirstOrDefault(s => s.Id == 1);
            //if (student != null)
            //{
            //    student.Name = "فاطمة راشد";
            //    student.Age = 25;
            //}
            //db.Students.Update(student);
            //db.SaveChanges();
            //Console.WriteLine("Student ID= " + student.Id + ", Student Name= " + student.Name + ", Student Age= " + student.Age);

            // حذف طالب - Delete Student
            //Console.WriteLine("Delete Student");
            //var deleteStudent = db.Students.FirstOrDefault();
            //db.Students.Remove(deleteStudent);
            //db.SaveChanges();
            //Console.WriteLine("Student ID= " + deleteStudent.Id + ", Student Name= " + deleteStudent.Name + ", Student Age= " + deleteStudent.Age);

            // البحث عن طالب بالرقم - Get Student by ID
            //Console.WriteLine("Get Student by ID");
            //var studentById = db.Students.FirstOrDefault(s => s.Id == 2);
            //if (studentById != null)
            //{
            //    Console.WriteLine("Student ID= " + studentById.Id + ", Student Name= " + studentById.Name + ", Student Age= " + studentById.Age);
            //}
            //else
            //{
            //    Console.WriteLine("Student not found");
            //}

            // عرض قائمة جميع الطلاب - Get List of All Students

            Console.WriteLine("Get List");
            var studentList = db.Students.ToList();
            foreach (var student in studentList)
            {
                Console.WriteLine("Student ID= " + student.Id + ", Student Name= " + student.Name + ", Student Age= " + student.Age);
            }
        }
    }
}

# EFProject
Student Management System - Hard Delete 🎓
العربية | Arabic
وصف المشروع
نظام إدارة الطلاب بسيط مبني باستخدام Entity Framework Core في .NET. يوفر عمليات CRUD أساسية (إنشاء، قراءة، تحديث، حذف) مع الحذف الصلب (Hard Delete) حيث يتم حذف البيانات نهائياً من قاعدة البيانات.
المميزات

✅ إضافة طالب جديد
✅ عرض جميع الطلاب
✅ البحث عن طالب بالرقم التسلسلي
✅ تحديث بيانات الطالب
✅ حذف طالب نهائياً
✅ اتصال مباشر بقاعدة بيانات SQL Server

التقنيات المستخدمة

اللغة: C#
الإطار: .NET Console Application
قاعدة البيانات: Entity Framework Core مع SQL Server
نمط التصميم: Code First Approach

هيكل المشروع
EFProject/
├── Models/
│   └── Student.cs          # نموذج الطالب
├── Data/
│   └── ApplicationDBContext.cs  # سياق قاعدة البيانات
└── Program.cs              # التطبيق الرئيسي
خصائص نموذج الطالب

Id: الرقم التسلسلي (مفتاح أساسي)
Name: اسم الطالب
Age: عمر الطالب

المتطلبات الأساسية

Visual Studio 2022 أو أحدث
.NET 6.0 أو أحدث
SQL Server (LocalDB أو Express)

التثبيت والإعداد
1. استنساخ المشروع
bashgit clone https://github.com/Fatmabriki/EFProject.git
cd EFProject
2. تثبيت الحزم المطلوبة
bashInstall-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.EntityFrameworkCore.Design
3. تحديث قاعدة البيانات
bashAdd-Migration InitialCreate
Update-Database
4. تشغيل التطبيق
bashdotnet run
كيفية الاستخدام
إضافة طالب جديد
csharp//Console.WriteLine("Add Student");
//var newStudent = new Student { Name = "فاطمة راشد", Age = 20 };
//db.Students.Add(newStudent);
//db.SaveChanges();
//Console.WriteLine("Student ID= " + newStudent.Id + ", Student Name= " + newStudent.Name + ", Student Age= " + newStudent.Age);
تحديث بيانات طالب
csharp//Console.WriteLine("Update Student");
//var student = db.Students.FirstOrDefault(s => s.Id == 1);
//if (student != null)
//{
//    student.Name = "فاطمة راشد";
//    student.Age = 22;
//}
//db.Students.Update(student);
//db.SaveChanges();
حذف طالب نهائياً
csharp//Console.WriteLine("Delete Student");
//var deleteStudent = db.Students.FirstOrDefault();
//db.Students.Remove(deleteStudent);
//db.SaveChanges();
عرض جميع الطلاب
csharpConsole.WriteLine("Get List");
var studentList = db.Students.ToList();
foreach (var student in studentList)
{
    Console.WriteLine("Student ID= " + student.Id + ", Student Name= " + student.Name + ", Student Age= " + student.Age);
}
نموذج الإخراج
Get List
Student ID= 1, Student Name= فاطمة راشد, Student Age= 20
Student ID= 2, Student Name=أحمد محسن , Student Age= 19
Student ID= 3, Student Name= محمد حسن, Student Age= 21

English
Project Description
A simple Student Management System built with Entity Framework Core in .NET. Provides basic CRUD operations (Create, Read, Update, Delete) with Hard Delete functionality where data is permanently removed from the database.
Features

✅ Add new student
✅ Display all students
✅ Search student by ID
✅ Update student information
✅ Permanently delete student
✅ Direct SQL Server database connection

Technologies Used

Language: C#
Framework: .NET Console Application
Database: Entity Framework Core with SQL Server
Design Pattern: Code First Approach

Project Structure
EFProject/
├── Models/
│   └── Student.cs          # Student model
├── Data/
│   └── ApplicationDBContext.cs  # Database context
└── Program.cs              # Main application
Student Model Properties

Id: Sequential number (Primary Key)
Name: Student name
Age: Student age

Prerequisites

Visual Studio 2022 or later
.NET 6.0 or later
SQL Server (LocalDB or Express)

Installation and Setup
1. Clone the repository
bashgit clone https://github.com/Fatmabriki/EFProject.git
cd EFProject
2. Install required packages
bashInstall-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
3. Update database
bashAdd-Migration InitialCreate
Update-Database
4. Run the application
bashdotnet run
Usage
Add New Student
csharp//Console.WriteLine("Add Student");
//var newStudent = new Student { Name = "Fatema Rashid", Age = 20 };
//db.Students.Add(newStudent);
//db.SaveChanges();
//Console.WriteLine("Student ID= " + newStudent.Id + ", Student Name= " + newStudent.Name + ", Student Age= " + newStudent.Age);
Update Student
csharp//Console.WriteLine("Update Student");
//var student = db.Students.FirstOrDefault(s => s.Id == 1);
//if (student != null)
//{
//    student.Name = "Fatema Rashid";
//    student.Age = 22;
//}
//db.Students.Update(student);
//db.SaveChanges();
Delete Student Permanently
csharp//Console.WriteLine("Delete Student");
//var deleteStudent = db.Students.FirstOrDefault();
//db.Students.Remove(deleteStudent);
//db.SaveChanges();
Display All Students
csharpConsole.WriteLine("Get List");
var studentList = db.Students.ToList();
foreach (var student in studentList)
{
    Console.WriteLine("Student ID= " + student.Id + ", Student Name= " + student.Name + ", Student Age= " + student.Age);
}
Sample Output
Get List
Student ID= 1, Student Name= Fatema Rashid, Student Age= 20
Student ID= 2, Student Name= Ahmed muhsen, Student Age= 19
Student ID= 3, Student Name= Mohamed Hassan, Student Age= 21
Contributing | المساهمة
Contributions are welcome! Please feel free to submit a Pull Request.
نرحب بالمساهمات! لا تتردد في إرسال Pull Request.
License | الترخيص
This project is licensed under the MIT License.
هذا المشروع مرخص تحت رخصة MIT.
Contact | التواصل

Email: fatmaburiki@gmail.com
GitHub: @Fatmabriki


⭐ إذا أعجبك هذا المشروع، لا تنس إعطاءه نجمة!
⭐ If you like this project, don't forget to give it a star!

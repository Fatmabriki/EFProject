using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Models
{
    public class Student
    {
        [Key] // المفتاح الأساسي
        public int Id { get; set; }
        public string Name { get; set; } // اسم الطالب
        public int Age { get; set; } // عمر الطالب
    }
}

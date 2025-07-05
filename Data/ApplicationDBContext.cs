using EFProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject.Data
{
    public class ApplicationDBContext : DbContext
    {
        // جدول الطلاب في قاعدة البيانات
        public virtual DbSet<Student> Students { get; set; }

        // إعداد الاتصال بقاعدة البيانات DbContextOptionsBuilder
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudentDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        }
    }
}

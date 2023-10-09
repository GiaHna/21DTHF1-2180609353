using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Bai2.Model
{
    public partial class StudentContextDB : DbContext
    {
        public StudentContextDB()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
       
    }
        
}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LeDinhPhuc_BigSchool.Models
{
    public partial class BigSchoolContext : DbContext
    {
        public BigSchoolContext()
            : base("name=BigSchoolContext1")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

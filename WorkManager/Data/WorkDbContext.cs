using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WorkManager.Models.Model
{
    public partial class WorkDbContext : DbContext
    {
        public WorkDbContext()
            : base("name=WorkDBContext")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Factory> Factories { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

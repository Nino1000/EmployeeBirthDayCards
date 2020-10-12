namespace EmployeeBirthDayCards.DataAccess.DBContextEntities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EmployeeContext : DbContext
    {
        public EmployeeContext()
            : base("name=EmployeeContext")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email_Address)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.User_Created)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.User_Changed)
                .IsUnicode(false);
        }
    }
}

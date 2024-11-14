using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmployeeService.Models
{
    public partial class dbCompanyContext : DbContext
    {
        public dbCompanyContext()
        {
        }

        public dbCompanyContext(DbContextOptions<dbCompanyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-NIK5L64\\KALVEY;Initial Catalog=dbCompany;Trusted_Connection=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Ssn);

                entity.Property(e => e.Ssn)
                    .HasColumnName("SSN")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Bdate).HasColumnType("date");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Minit)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Salary).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SuperSsn)
                    .HasColumnName("Super_ssn")
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });
        }
    }
}

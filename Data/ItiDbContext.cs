using Microsoft.EntityFrameworkCore;
using Solv_Assignment_EF_2.DB_Context;

namespace Solv_Assignment_EF_2.Data
{
    public class ItiDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> StudCourses { get; set; }
        public DbSet<Course_Inst> CourseInstructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=.;Database=SolvAssignmentEF;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(e =>
            {
                e.ToTable("Student");
                e.HasKey(x => x.Id);

                e.Property(x => x.FName).HasMaxLength(50).IsRequired();
                e.Property(x => x.LName).HasMaxLength(50).IsRequired();
                e.Property(x => x.Address).HasMaxLength(200);

                e.HasOne(x => x.Department)
                 .WithMany(d => d.Students)
                 .HasForeignKey(x => x.Dep_Id)
                 .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Department>(e =>
            {
                e.ToTable("Department");
                e.HasKey(x => x.Id);

                e.Property(x => x.Name).HasMaxLength(100).IsRequired();

                e.HasOne(d => d.Head)
                 .WithOne(i => i.HeadOf)
                 .HasForeignKey<Department>(d => d.Ins_ID)
                 .HasPrincipalKey<Instructor>(i => i.ID)
                 .OnDelete(DeleteBehavior.Restrict);

                e.HasIndex(d => d.Ins_ID).IsUnique().HasFilter("[Ins_ID] IS NOT NULL");
            });

            modelBuilder.Entity<Instructor>(e =>
            {
                e.ToTable("Instructor");
                e.HasKey(x => x.ID);

                e.Property(x => x.Name).HasMaxLength(100).IsRequired();
                e.Property(x => x.Address).HasMaxLength(200);
                e.Property(x => x.Salary).HasColumnType("decimal(18,2)");
                e.Property(x => x.HourRateBouns).HasColumnType("decimal(18,2)");

                e.HasOne(x => x.Department)
                 .WithMany(d => d.Instructors)
                 .HasForeignKey(x => x.Dept_ID)
                 .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Topic>(e =>
            {
                e.ToTable("Topic");
                e.HasKey(x => x.ID);

                e.Property(x => x.Name).HasMaxLength(100).IsRequired();
            });

            modelBuilder.Entity<Course>(e =>
            {
                e.ToTable("Course");
                e.HasKey(x => x.ID);

                e.Property(x => x.Name).HasMaxLength(100).IsRequired();
                e.Property(x => x.Description).HasMaxLength(500);

                e.HasOne(x => x.Topic)
                 .WithMany(t => t.Courses)
                 .HasForeignKey(x => x.Top_ID)
                 .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Stud_Course>(e =>
            {
                e.ToTable("Stud_Course");
                e.HasKey(x => new { x.Stud_ID, x.Course_ID });

                e.Property(x => x.Grade).HasColumnType("decimal(5,2)");

                e.HasOne(x => x.Student)
                 .WithMany(s => s.Stud_Courses)
                 .HasForeignKey(x => x.Stud_ID)
                 .OnDelete(DeleteBehavior.Cascade);

                e.HasOne(x => x.Course)
                 .WithMany(c => c.Stud_Courses)
                 .HasForeignKey(x => x.Course_ID)
                 .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Course_Inst>(e =>
            {
                e.ToTable("Course_Inst");
                e.HasKey(x => new { x.inst_ID, x.Course_ID });

                e.Property(x => x.Evaluate).HasMaxLength(200);

                e.HasOne(x => x.Instructor)
                 .WithMany(i => i.CourseInstructors)
                 .HasForeignKey(x => x.inst_ID)
                 .OnDelete(DeleteBehavior.Cascade);

                e.HasOne(x => x.Course)
                 .WithMany(c => c.Course_Instructors)
                 .HasForeignKey(x => x.Course_ID)
                 .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}

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
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-SMBVS1T;Database=ITI_DB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Student>()
                .Property(s => s.FName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Student>()
                .Property(s => s.LName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Student>()
                .ToTable(t =>
                {
                    t.HasCheckConstraint("CK_Student_Age", "[Age] >= 18");
                });

            modelBuilder.Entity<Department>()
                .HasIndex(d => d.Name).IsUnique();
            modelBuilder.Entity<Department>()
                .ToTable(t =>
                {
                    t.HasCheckConstraint("CK_Department_HiringDate", "[HiringDate] <= GETDATE()");
                });
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Head)
                .WithMany()
                .HasForeignKey(d => d.Ins_ID)
                .OnDelete(DeleteBehavior.Restrict);

          
            modelBuilder.Entity<Course>()
                .HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Course>()
                .ToTable(t =>
                {
                    t.HasCheckConstraint("CK_Course_Duration", "[Duration] > 0");
                });

        
            modelBuilder.Entity<Instructor>()
                .ToTable(t =>
                {
                    t.HasCheckConstraint("CK_Instructor_Salary", "[Salary] > 0");
                    t.HasCheckConstraint("CK_Instructor_HourRateBouns", "[HourRateBouns] >= 0");
                });
            modelBuilder.Entity<Instructor>()
                .Property(i => i.HourRateBouns)
                .HasColumnType("decimal(10,2)")
                .HasDefaultValue(0);

        
            modelBuilder.Entity<Topic>()
                .HasIndex(t => t.Name).IsUnique();

            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.Stud_ID, sc.Course_ID });
            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Student)
                .WithMany(s => s.StudCourses)
                .HasForeignKey(sc => sc.Stud_ID);
            modelBuilder.Entity<Stud_Course>()
                .HasOne(sc => sc.Course)
                .WithMany(c => c.StudCourses)
                .HasForeignKey(sc => sc.Course_ID);
            modelBuilder.Entity<Stud_Course>()
                .ToTable(t =>
                {
                    t.HasCheckConstraint("CK_Stud_Course_Grade", "[Grade] BETWEEN 0 AND 100");
                });

            
            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.inst_ID, ci.Course_ID });
            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Instructor)
                .WithMany(i => i.CourseInstructors)
                .HasForeignKey(ci => ci.inst_ID);
            modelBuilder.Entity<Course_Inst>()
                .HasOne(ci => ci.Course)
                .WithMany(c => c.CourseInstructors)
                .HasForeignKey(ci => ci.Course_ID);
            modelBuilder.Entity<Course_Inst>()
     .ToTable(t =>
     {
         t.HasCheckConstraint("CK_CourseInst_Evaluate", "[Evaluate] BETWEEN 1 AND 10");
     });

        }
    }
}

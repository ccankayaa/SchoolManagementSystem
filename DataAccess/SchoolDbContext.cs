using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Models;


namespace SchoolManagementSystem.DataAccess
{
    public class SchoolDbContext : IdentityDbContext<User>
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true); //PostgreSQL .net date time formatini kabul etmesi icin
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Classroom>()
                .HasMany(c => c.Students)
                .WithOne(c => c.Classroom)
                .HasForeignKey(c => c.ClassroomId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Student>()
                .HasOne(c => c.Classroom)
                .WithMany(c => c.Students)
                .HasForeignKey(c => c.ClassroomId)
                .IsRequired();

            builder.Entity<Student>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Teacher>()
                .HasOne(c => c.Classroom)
                .WithOne(c => c.Teacher)
                .HasForeignKey<Teacher>(c => c.ClassroomId);


            builder.Entity<Teacher>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Classroom>()
                .HasOne(c => c.Teacher)
                .WithOne(c => c.Classroom)
                .HasForeignKey<Classroom>(c => c.TeacherId)
                .OnDelete(DeleteBehavior.NoAction);

            //builder.Entity<IdentityUser>(i =>
            //{
            //    i.Property<UserType>("UserType");
            //});



            base.OnModelCreating(builder);
        }

    }
}

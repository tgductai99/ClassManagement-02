using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TaskQLLH.Authorization.Roles;
using TaskQLLH.Authorization.Users;
using TaskQLLH.MultiTenancy;
using TaskQLLH.ClassRooms;

namespace TaskQLLH.EntityFrameworkCore
{
    public class TaskQLLHDbContext : AbpZeroDbContext<Tenant, Role, User, TaskQLLHDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DbSet<ClassRoom> ClassRooms { get; set; }
        
        public TaskQLLHDbContext(DbContextOptions<TaskQLLHDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClassRoom>(b =>
            {
                b.ToTable("ClassRooms");
                b.Property(x => x.ClassName)
                    .IsRequired()
                    .HasMaxLength(ClassRoom.MaxClassNameLength);
                b.Property(x => x.AcademicYear)
                    .IsRequired()
                    .HasMaxLength(ClassRoom.MaxAcademicYearLength);
                b.Property(x => x.Description)
                    .HasMaxLength(ClassRoom.MaxDescriptionLength);

                // Unique: không được có 2 lớp cùng tên trong cùng năm học
                b.HasIndex(x => new { x.ClassName, x.AcademicYear }).IsUnique();
            });
        }
    }
}

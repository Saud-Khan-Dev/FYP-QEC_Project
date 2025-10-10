using Microsoft.EntityFrameworkCore;

public class DBContext : DbContext
{

       public DBContext(DbContextOptions<DBContext> options) : base(options)
       {

       }

       public DbSet<AdminModel> Admin { get; set; }
       public DbSet<FacultyModel> Faculty { get; set; }
       public DbSet<CourseModel> Course { get; set; }
       public DbSet<CLOModel> CLO { get; set; }



       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {


              modelBuilder.Entity<AdminModel>(entity =>
              {
                     entity.HasKey(t => t.Id);
                     entity.Property(t => t.Name)
                     .HasMaxLength(100).IsRequired(true)
                     .HasMaxLength(100);
                     entity.Property(t => t.Email)
                     .HasMaxLength(200).IsRequired();
                     entity.Property(t => t.PhoneNumber)
                     .HasMaxLength(50).IsRequired();
                     entity.Property(t => t.PasswordHash)
                     .HasMaxLength(255).IsRequired();
                     entity.Property(t => t.Role).HasDefaultValue(Role.Admin)
                     .HasMaxLength(20).IsRequired();
                     entity.Property(t => t.Gender)
                     .HasMaxLength(90).IsRequired();
                     entity.Property(t => t.DateOfJoining)
                     .IsRequired();

              });

              modelBuilder.Entity<FacultyModel>(
        entity =>
        {
               entity.HasKey(t => t.Id);
               entity.Property(t => t.Name)
               .HasMaxLength(100).IsRequired(true)
               .HasMaxLength(100);
               entity.Property(t => t.Email)
               .HasMaxLength(200).IsRequired();
               entity.Property(t => t.PhoneNumber)
               .HasMaxLength(50).IsRequired();
               entity.Property(t => t.PasswordHash)
               .HasMaxLength(255).IsRequired();
               entity.Property(t => t.Role).HasDefaultValue(Role.Faculty)
               .HasMaxLength(20).IsRequired();
               entity.Property(t => t.Gender)
               .HasMaxLength(90).IsRequired();
               entity.Property(t => t.EmployeeId)
               .IsRequired()
               .HasMaxLength(80);
               entity.Property(t => t.Department)
               .IsRequired()
               .HasMaxLength(100);
               entity.Property(t => t.Designation)
               .IsRequired()
               .HasMaxLength(100);
               entity.Property(t => t.DateOfJoining)
               .IsRequired();
        }
    );

              modelBuilder.Entity<CourseModel>(
               entity =>
               {

                      entity.HasKey(c => c.Id);

                      entity.Property(c => c.CourseCode)
                   .IsRequired()
                   .HasMaxLength(50);

                      entity.Property(c => c.Description)
                   .HasMaxLength(500);

                      entity.Property(c => c.TheoreyCreditHours)
                   .IsRequired();

                      entity.Property(c => c.LabCreditHours)
                   .IsRequired();

                      entity.Property(c => c.IsActive)
                   .HasDefaultValue(true);

                      entity.Property(c => c.CreatedAt)
                   .IsRequired();

                      entity.HasMany(c => c.CLO)
            .WithOne(c => c.Course)
            .HasForeignKey(fk => fk.CourseId)
            .OnDelete(DeleteBehavior.Cascade);
               }
              );
              modelBuilder.Entity<CLOModel>(
                  entity =>
                  {

                         entity.HasKey(t => t.Id);
                         entity.Property(t => t.CLOName)
               .IsRequired()
               .HasMaxLength(100);
                         entity.Property(t => t.Description)
               .IsRequired()
               .HasMaxLength(2000);
                         entity.Property(t => t.UnitNumber)
               .IsRequired()
               .HasMaxLength(100);
                  }
              );


       }
}
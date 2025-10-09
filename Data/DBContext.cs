using Microsoft.EntityFrameworkCore;

public class DBContext : DbContext
{

  public DBContext(DbContextOptions<DBContext> options) : base(options)
  {

  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<User>(
entity =>
{
  entity.HasKey(t => t.Id);
  entity.Property(t => t.Name)
  .HasMaxLength(100).IsRequired(true);
  entity.Property(t => t.Email)
  .HasMaxLength(200).IsRequired(true);
  entity.Property(t => t.Name)
  .HasMaxLength(100).IsRequired(true);
  entity.Property(t => t.Name)
  .HasMaxLength(100).IsRequired(true);
}

    );

  }
}
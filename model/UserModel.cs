using System.ComponentModel.DataAnnotations;

public class User
{
  [Key]
  public int Id { get; set; }

  [Required]
  [MaxLength(100)]
  public string Name { get; set; }

  [Required]
  [EmailAddress]
  [MaxLength(100)]
  public string Email { get; set; }

  [Required]
  [MaxLength(15)]
  public string PhoneNumber { get; set; }

  [Required]
  [MaxLength(255)]
  public string PasswordHash { get; set; }

  [Required]
  [MaxLength(20)]
  public Role Role { get; set; }

  [Required]
  [MaxLength(80)]
  public string Gender { get; set; }

  public DateTime CreatedAt { get; set; } = DateTime.Now;

  public bool IsActive { get; set; } = true;
}
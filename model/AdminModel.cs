using System.ComponentModel.DataAnnotations;

public class AdminModel
{
  [Key]
  public int Id;

  [Required]
  public string Name { get; set; }

  [Required]
  public IContactType Contact { get; set; }

  public DateTime CreatedAt = DateTime.Now;

}
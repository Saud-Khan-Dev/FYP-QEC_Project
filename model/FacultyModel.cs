using System.ComponentModel.DataAnnotations;

public class FacultyModel
{
  [Key]
  public int Id;

  [Required]
  public string Name { get; set; } = null;

  [Required]
  public string Gender { get; set; }
  [Required]
  public int Age { get; set; }

  [Required]
  public string Address { get; set; }

  [Required]
  public IContactType Contact { get; set; }

  [Required]
  public EducationLevel EducationLevel { get; set; }

}
using System.ComponentModel.DataAnnotations;

public class CourseModel
{
  [Key]
  public int Id { get; set; }

  [Required]
  public string CourseCode { get; set; }

  public string Description { get; set; }

  public int TheoreyCreditHours { get; set; }

  public int LabCreditHours { get; set; }

  public List<CLOModel> CLO { get; set; } = new List<CLOModel>();
  public bool IsActive { get; set; } = true;

  public DateTime CreatedAt = DateTime.Now;
}



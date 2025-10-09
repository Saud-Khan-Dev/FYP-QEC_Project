using System.ComponentModel.DataAnnotations;

public class CourseModel
{
  [Key]
  public int Id;

  [Required]
  public string CourseCode { get; set; }

  public string Description { get; set; }

  public int TheoreyCreditHours { get; set; }

  public int LabCreditHours { get; set; }

  public ICLO[] CLO { get; set; }
  public bool IsActive { get; set; }

  public DateTime CreatedAt = DateTime.Now;
}



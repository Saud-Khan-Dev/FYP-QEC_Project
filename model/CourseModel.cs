using System.ComponentModel.DataAnnotations;

public class CourseModel
{
  public int Id { get; set; }

  [Required]
  public string CourseCode { get; set; }

  public string Description { get; set; }

  public int TheoreyCreditHours { get; set; }

  public int LabCreditHours { get; set; }

  public IList<CLOModel> CLO { get; set; }
  public bool IsActive { get; set; } = true;

  public IList<XrefFacultyCourses>XrefFacultyCourses  { get; set; }

  public DateTime CreatedAt = DateTime.Now;
}



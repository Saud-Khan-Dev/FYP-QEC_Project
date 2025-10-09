using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CLOModel
{
  public int Id { get; set; }
  public string CLOName { get; set; }
  public string description { get; set; }
  public string UnitNumber { get; set; }

  [Required]
  public int CourseId { get; set; }

  [ForeignKey("CourseId")]
  public CourseModel Course { get; set; }

}
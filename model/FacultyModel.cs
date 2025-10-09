using System.ComponentModel.DataAnnotations;

public class FacultyModel : User
{
  [Required]
  [MaxLength(20)]
  public string EmployeeId { get; set; }

  [Required]
  [MaxLength(100)]
  public string Department { get; set; }

  [MaxLength(100)]
  public string Designation { get; set; }

}
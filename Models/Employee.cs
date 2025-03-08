
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace  firstone.Models{

public class Employees
{
    [Key]
    public int Id { get; set; }
    public String Code { get; set; } = null!;
    [Required]
    public String FirstName { get; set; } = null!;
    [Required]

    public String LastName { get; set; } = null!;
    public String Gender { get; set; } = null!;
    [Required]

    public String Email { get; set; } = null!;
    public String Phone { get; set; } = null!;

    public String JobTitle { get; set; } = null!;


}

}
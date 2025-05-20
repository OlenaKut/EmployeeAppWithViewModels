using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Views.Employees;

public class CreateVM
{
    
    public required string Name { get; set; }

    [EmailAddress(ErrorMessage = "Invalid e-mail address.")]
    public required string Email { get; set; }

    [Range(4, 4, ErrorMessage = "Incorrect answer. What is 2 + 2?")]
    public int BotCheck { get; set; }

}

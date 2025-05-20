using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Views.Employees;

public class IndexVM
{
     public required EmployeeItemVM[] EmployeeItems { get; set; }
        public class EmployeeItemVM
        {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }


        [Required(ErrorMessage = "Enter an admins Email")]
        public bool ShowAsHighlighted { get; set; } = false;

    }

}

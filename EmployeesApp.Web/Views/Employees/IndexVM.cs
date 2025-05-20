using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Views.Employees;

public class IndexVM
{
    public required EmployeeItemVM[] EmployeeItems { get; set; } = null!;

        public class EmployeeItemVM
        {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }

        public required bool ShowAsHighlighted { get; set; } = false;

    }

}

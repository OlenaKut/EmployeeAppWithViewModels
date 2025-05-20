using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Views.Employees
{
    public class DetailsVM
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public required string Email { get; set; }

        public bool NameStartsWithA { get; set; }

    }
}


using EmployeesApp.Web.Models;
using EmployeesApp.Web.Views.Employees;

using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApp.Web.Controllers
{
    public class EmployeesController : Controller
    {
        static EmployeeService service = new EmployeeService();

        [HttpGet("")]
        public IActionResult Index()
        {
            var model = service.GetAll();

            var viewModel = new IndexVM
            {
                EmployeeItems = model
                .Select(o => new IndexVM.EmployeeItemVM
                {
                    Id = o.Id,
                    Name = o.Name,
                    Email = o.Email,
                    ShowAsHighlighted = o.Email.StartsWith("admin")
                })
                .ToArray()
            };


            //foreach (var emp in model)
            //    Console.WriteLine($"{emp.Name}: {emp.Id}");

            return View(viewModel);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(CreateVM viewModel)
        {
            if (!ModelState.IsValid)
                return View();

            var model = new Employee
            {
                Name = viewModel.Name,
                Email = viewModel.Email
            };

            service.Add(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            var model = service.GetById(id);
            return View(model);
        }
    }
}

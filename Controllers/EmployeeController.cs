using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASPDotNet_CORE_WebApplication.Repository;

namespace ASPDotNet_CORE_WebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IRepositoryEmployee _employeeService;
        public EmployeeController(IRepositoryEmployee serviceEmployee)
        {
            _employeeService = serviceEmployee;
        }
        public IActionResult Employee1()
        {
            var valemployees = _employeeService.GetAll();
            return View(valemployees);
        }
        public IActionResult AddNewEmployee()
        {
            return View();
        }
        public IActionResult UpdateEmployee(int id)
        {
            var employee = _employeeService.GetById(id);
            return View("UpdateEmployee", employee);

        }
        public IActionResult DeleteEmployee(int id)
        {
            var employee = _employeeService.GetById(id);
            return View("UpdateEmployee", employee);
        }
    }
}

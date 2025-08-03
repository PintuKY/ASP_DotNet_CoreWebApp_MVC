using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASPDotNet_CORE_WebApplication.Models;
using ASPDotNet_CORE_WebApplication.Services;

namespace ASPDotNet_CORE_WebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IServicesEmployee _employeeService;
        public EmployeeController(IServicesEmployee serviceEmployee)
        {
            _employeeService = serviceEmployee;
        }
        public IActionResult Employee()
        {
            var employees = _employeeService.GetAll();
            return View(employees);
        }
    }
}

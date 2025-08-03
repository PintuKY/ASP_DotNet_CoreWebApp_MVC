using System.Collections.Generic;
using System.Linq;
using ASPDotNet_CORE_WebApplication.Models;

namespace ASPDotNet_CORE_WebApplication.Services
{
    public class EmployeeServices : IServicesEmployee
    {
        private static List<EmployeeModel> _employees = new List<EmployeeModel>()
        {
            new EmployeeModel { Id = 1, Name = "Pintu", Department = "IT", Salary = 2000, Age = 20, MobileNo = 3984939493 },
            new EmployeeModel { Id = 2, Name = "Krishna", Department = "HR", Salary = 2000, Age = 20, MobileNo = 3984939493 }
        };

        public List<EmployeeModel> GetAll()
        {
            return _employees;
        }

        public EmployeeModel GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public void Add(EmployeeModel employee)
        {
            _employees.Add(employee);
        }
    }
}

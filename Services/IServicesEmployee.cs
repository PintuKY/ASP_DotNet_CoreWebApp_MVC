using ASPDotNet_CORE_WebApplication.Models;


namespace ASPDotNet_CORE_WebApplication.Services
{
    public interface IServicesEmployee
    {
        List<EmployeeModel> GetAll();
        EmployeeModel GetById(int id);
        void Add(EmployeeModel employee);
    }
}

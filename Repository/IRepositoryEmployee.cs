using ASPDotNet_CORE_WebApplication.Models;

namespace ASPDotNet_CORE_WebApplication.Repository
{
    public interface IRepositoryEmployee
    {
        IEnumerable<Employees> GetAll();

        Employees GetById(int id);
        void Add(Employees employee);
        void Update(Employees employee);
        void Delete(int id);
    }
}

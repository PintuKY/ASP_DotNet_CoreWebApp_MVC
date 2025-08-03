using ASPDotNet_CORE_WebApplication.Models;
using ASPDotNet_CORE_WebApplication.AddDbcontext;


namespace ASPDotNet_CORE_WebApplication.Repository
{
    public class EmpRepository : IRepositoryEmployee
    {
        private readonly AppDbContext _context;
        public EmpRepository(AppDbContext comtext) 
        {
            _context = comtext;
        }

        public IEnumerable<Employees> GetAll()
        {
            return _context.TblEmployees;
        }
        public Employees GetById(int id)
        {
            return _context.TblEmployees.Find(id);
        }
        public void Add(Employees employee)
        {
            _context.TblEmployees.Add(employee);
            _context.SaveChanges();
        }
        public void Update(Employees employee)
        {
            _context.TblEmployees.Remove(employee);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var employee = _context.TblEmployees.Find(id);
            if (employee != null)
            {
                _context.TblEmployees.Remove(employee);
                _context.SaveChanges();
            }
        }
    }
}

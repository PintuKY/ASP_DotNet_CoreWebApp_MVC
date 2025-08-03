using ASPDotNet_CORE_WebApplication.Services;
namespace ASPDotNet_CORE_WebApplication.Models
{
    public class EmployeeModel
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        public UInt32 MobileNo { get; set; }


    }
}

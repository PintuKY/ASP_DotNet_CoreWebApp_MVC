using ASPDotNet_CORE_WebApplication.Services;
using System.ComponentModel.DataAnnotations.Schema;
namespace ASPDotNet_CORE_WebApplication.Models
{

    [Table("Employees")]
    public class Employees
    {
        public int Id {  get; set; }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public string? MobileNo { get; set; }


    }
}

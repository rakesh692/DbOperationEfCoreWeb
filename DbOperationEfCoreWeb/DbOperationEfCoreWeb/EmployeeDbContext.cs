using Microsoft.EntityFrameworkCore;

namespace DbOperationEfCoreWeb
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions option):base(option)
        {
                
        }
        public DbSet<Employee> Employees { get; set; }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeCity { get; set; }
            
    }
}

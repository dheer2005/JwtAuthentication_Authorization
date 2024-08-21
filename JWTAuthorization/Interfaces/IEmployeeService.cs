using JWTAuthorization.Models;

namespace JWTAuthorization.Interfaces
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployeeDetails();
        public Employee AddEmployee(Employee employee); 
    }
}

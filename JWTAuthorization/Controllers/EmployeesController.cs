using JWTAuthorization.Interfaces;
using JWTAuthorization.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWTAuthorization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "User,Admin")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService; 
        }

        // GET: api/<EmployeesController>
        [HttpGet]
        [Authorize(Roles = "User,Admin")]
        public List<Employee> GetEmployee()
        {
            return _employeeService.GetEmployeeDetails();   
        }

        
        [HttpPost]
        [Authorize]
        public Employee AddEmployee([FromBody] Employee emp)
        {
            var employee = _employeeService.AddEmployee(emp);
            return employee;
        }

    }
}

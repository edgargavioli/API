using API.Model;
using API.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase //É mais adequado para o uso em APIs
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository) 
            => _employeeRepository = employeeRepository;
        
        [HttpPost]
        public IActionResult Add(EmployeeViewModel employeeView)
        {
            var employee = new Employee(employeeView.Name, employeeView.Age, null);

            _employeeRepository.Add(employee);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employees = _employeeRepository.Get();

            return Ok(employees);
        }
    }
}

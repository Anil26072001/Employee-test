using Microsoft.AspNetCore.Mvc;
using WebApITest.Data;
using WebApITest.Models;
using WebApITest.NewFolder;

namespace WebApITest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController: ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public System.Collections.IEnumerable GetEmployees()
        {
            return _context.Employee.ToList();
        }

        [HttpPost]
        [Route("api/EmpDetails/Postemployee")]
        public int EmployeePost(Employee emp)
        {
            try
            {
                if (_context == null)
                {
                    NotFound();
                }

                
                _context.Employee.Add(emp);
               int i=  _context.SaveChanges();

                return i;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}

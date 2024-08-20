using Microsoft.AspNetCore.Mvc;

namespace WebAppDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeList()
        {
            return View();
        }
        public IActionResult AddEmployeeDetail()
        {
            return View();
        }
    }
}

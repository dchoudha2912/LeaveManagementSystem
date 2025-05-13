using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            TestViewModel testViewModel = new TestViewModel { Name = "Photons",
            DateOfBirth = new DateTime(1996, 12, 29)
            };

            return View(testViewModel);
        }
    }
}

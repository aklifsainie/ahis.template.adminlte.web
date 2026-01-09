using Microsoft.AspNetCore.Mvc;

namespace swg.net8.adminlte.web.Controllers
{

    public class EnrolmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult NewEnrolment()
        {
            return View();
        }
    }
}

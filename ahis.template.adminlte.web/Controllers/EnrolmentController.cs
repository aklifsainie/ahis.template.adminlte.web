using Microsoft.AspNetCore.Mvc;

namespace ahis.template.adminlte.web.Controllers
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

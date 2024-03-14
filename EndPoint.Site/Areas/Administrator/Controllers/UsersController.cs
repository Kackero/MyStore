using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Site.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

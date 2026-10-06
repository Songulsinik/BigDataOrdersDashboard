using Microsoft.AspNetCore.Mvc;

namespace BigDataOrdersDashboard.Controllers
{
    public class CustomerDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

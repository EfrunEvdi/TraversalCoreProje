using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

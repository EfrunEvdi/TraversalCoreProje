using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProje.ViewComponents.AdminDashboard
{
    public class _Card1Statistic : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.DC = c.Destinations.Count();
            ViewBag.UC = c.Users.Count();
            return View();
        }
    }
}

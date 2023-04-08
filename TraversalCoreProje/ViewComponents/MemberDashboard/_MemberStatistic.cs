using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberDashboard
{
    public class _MemberStatistic : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}

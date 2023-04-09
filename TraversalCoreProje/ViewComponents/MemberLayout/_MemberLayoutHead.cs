using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberLayout
{
    public class _MemberLayoutHead : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

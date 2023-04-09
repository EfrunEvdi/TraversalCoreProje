using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberLayout
{
    public class _MemberLayoutNavbar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

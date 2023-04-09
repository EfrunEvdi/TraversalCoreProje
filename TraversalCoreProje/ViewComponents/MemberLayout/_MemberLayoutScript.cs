using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberLayout
{
    public class _MemberLayoutScript : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

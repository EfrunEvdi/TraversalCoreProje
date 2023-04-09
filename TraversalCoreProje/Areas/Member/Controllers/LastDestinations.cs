using BusinessLayer.Abstarct;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    public class LastDestinations : Controller
    {
        private readonly IDestinationService _destinationService;

        public LastDestinations(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetLast4Destinations();
            return View(values);
        }
    }
}

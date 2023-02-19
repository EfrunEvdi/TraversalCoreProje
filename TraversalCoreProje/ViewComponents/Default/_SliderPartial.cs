using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.ConstrainedExecution;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

  /* 
    * - Partial View’de bir veri bize döndürücekse bunu mutlaka Contollerden alması gerekmektedir.
    * - Her bir View’in Partiala Controller üzerinden veri göndermek hem Controller maliyetini attırııcaktır hem de Controllera amacını saptıracaktır.
    * - PartialView yapılanması ihtiyacı olan dataları Controller üzerinden elde edeceği için Controller’daki maliyeti artırmakta ve SOLID prensiplerine aykırı davranılmasına sebebiyet verebilmektedir.
    * - PartiView yapısal olarak controller üzerinden beslenmektedir.
    * - *ViewCompenent* ihtiyacı olan dataları controller üzerinden değil direkt kendi cs.dosyasında elde edebilmektedir.Böylece controllerdaki luzumsuz maliyeti ortadan kaldırmış olmaktayız.
  */
}

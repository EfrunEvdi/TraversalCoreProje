using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstarct
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetListApprovalReservation(int id);
    }
}

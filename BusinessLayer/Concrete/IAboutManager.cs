using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public interface IAboutManager
    {
        void TAdd(About t);
        void TDelete(About t);
        About TGetByID(int id);
        List<About> TGetList();
        void TUpdate(About t);
    }
}
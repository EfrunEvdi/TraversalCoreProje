using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TraversalCoreProje.CQRS.Queries.DestinationQueries;
using TraversalCoreProje.CQRS.Result.DestinationResults;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                id = x.DestinationID,
                capacity = x.Capacity,
                city = x.City,
                daynight = x.DayNight,
                price = x.Price,
            }).AsNoTracking().ToList();
            // AsNoTracking() sorusuna yanıt olarak ; Entity'ler üzerindeki işlemler sürekli izlenir. Bir Entity'de değişiklik, güncelleme yapıldıysa SaveChanges() metodu ile bu değişiklikler veritabanına yansıtılır.  Bu şekilde entity üzerindeki değişiklik kalıcı hale getirilir.Fakat biz herzaman entity'ler üzerinde değişiklik yapmayız. Çoğu zaman sadece okumaya dayalı işlemler yaparız. Varsayılan olarak Enitity Framework üzerinde yaptığımız işlemlerde bu "takip" aktif durumdadır. Çoğu zamanda okuma işlemi yaptığımız için bu performans kaybına yol açar.İşte bu durumda izleme yapmadan, sadece okunabilir işlemler için AsNoTracking kullanılır.  AsNoTracking kullanıldığında Entity üzerinde değişiklik var mı yok mu  Context tarafından izlemenmez.
            return values;
        }
    }
}

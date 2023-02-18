using Tickits.Data.Base;
using Tickits.Models;

namespace Tickits.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {

        }
    }
}

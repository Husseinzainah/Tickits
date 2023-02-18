using Tickits.Data.Base;
using Tickits.Models;

namespace Tickits.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {

        }
    }
}

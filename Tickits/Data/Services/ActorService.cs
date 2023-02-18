using Microsoft.EntityFrameworkCore;
using Tickits.Data.Base;
using Tickits.Models;

namespace Tickits.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>,IActorsService
    {
        
        public ActorService(AppDbContext context) : base(context) { }
       

    }
}

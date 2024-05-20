using VKTiketsPG.Data.Base;
using VKTiketsPG.Models;

namespace VKTiketsPG.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>,IProducersService
    {
        public ProducersService(AppDbContext context) : base(context) { }
    }
}

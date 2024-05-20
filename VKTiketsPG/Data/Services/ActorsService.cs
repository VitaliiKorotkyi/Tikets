using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VKTiketsPG.Data.Base;
using VKTiketsPG.Models;

namespace VKTiketsPG.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>,IActorsService 
    {
        public ActorsService(AppDbContext context):base(context)
        {
        }
 
    }
}

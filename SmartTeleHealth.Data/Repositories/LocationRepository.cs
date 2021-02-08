using SmartTeleHealth.Data.Infrastructure;
using SmartTeleHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTeleHealth.Data.Repositories
{
    public class LocationRepository : Repository<Location>, ILocationRepository
    {
        public LocationRepository(ApplicationDbContext context) : base(context)
        {

        }
    }

    public interface ILocationRepository : IRepository<Location>
    {

    }
}

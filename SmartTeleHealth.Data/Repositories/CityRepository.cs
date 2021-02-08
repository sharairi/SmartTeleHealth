using SmartTeleHealth.Data.Infrastructure;
using SmartTeleHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTeleHealth.Data.Repositories
{
    public interface ICityRepository : IRepository<City>
    { 

    }
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}

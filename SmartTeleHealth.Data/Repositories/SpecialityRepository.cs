using SmartTeleHealth.Data.Infrastructure;
using SmartTeleHealth.Models;
using System;

namespace SmartTeleHealth.Data.Repositories
{
    public class SpecialityRepository : Repository<Speciality>, ISpecialityRepository
    {
        public SpecialityRepository(ApplicationDbContext context) : base(context)
        {
        }
    }

    public interface ISpecialityRepository : IRepository<Speciality>
    {

    }
}

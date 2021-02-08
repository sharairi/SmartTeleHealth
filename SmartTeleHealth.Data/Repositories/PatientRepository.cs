using SmartTeleHealth.Data.Infrastructure;
using SmartTeleHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTeleHealth.Data.Repositories
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        public PatientRepository(ApplicationDbContext context) : base(context)
        {
        }
    }

    public interface IPatientRepository : IRepository<Patient>
    {
    }
}

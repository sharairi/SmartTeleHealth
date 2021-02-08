﻿using SmartTeleHealth.Data.Infrastructure;
using SmartTeleHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTeleHealth.Data.Repositories
{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
        private ApplicationDbContext db;
        public UserRepository(ApplicationDbContext context) : base(context)
        {
            this.db = context;
        }
    }

    public interface IUserRepository : IRepository<ApplicationUser>
    {
        
    }
}

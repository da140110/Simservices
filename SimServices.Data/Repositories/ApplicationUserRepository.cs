﻿using System.Collections.Generic;
using System.Linq;
using SimServices.Data.Infrastructure;
using SimServices.Model.Models;

namespace SimServices.Data.Repositories
{
    public interface IApplicationUserRepository : IRepository<ApplicationUserGroup>
    {
        
    }

    public class ApplicationUserRepository : RepositoryBase<ApplicationUserGroup>, IApplicationUserRepository
    {
        public ApplicationUserRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
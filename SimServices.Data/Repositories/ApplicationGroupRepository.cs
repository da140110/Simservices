using System.Collections.Generic;
using System.Linq;
using SimServices.Data.Infracstructure;
using SimServices.Model.Models;

namespace SimServices.Data.Repositories
{
    public interface IApplicationGroupRepository
    {
        
    }

    public class ApplicationGroupRepository : RepositoryBase<ApplicationGroup>, IApplicationGroupRepository
    {
        public ApplicationGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
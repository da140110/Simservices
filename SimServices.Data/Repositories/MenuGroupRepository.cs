using System.Collections.Generic;
using System.Linq;
using SimServices.Data.Infracstructure;
using SimServices.Model.Models;

namespace SimServices.Data.Repositories
{
    public interface IMenuGroupRepository
    {
        
    }

    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
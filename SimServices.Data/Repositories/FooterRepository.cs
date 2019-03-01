using System.Collections.Generic;
using System.Linq;
using SimServices.Data.Infrastructure;
using SimServices.Model.Models;

namespace SimServices.Data.Repositories
{
    public interface IFooterRepository : IRepository<Footer>
    {
        
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
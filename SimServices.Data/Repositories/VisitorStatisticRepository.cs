using System.Collections.Generic;
using System.Linq;
using SimServices.Data.Infracstructure;
using SimServices.Model.Models;

namespace SimServices.Data.Repositories
{
    public interface IVisitorStatisticRepository
    { 

    }

    public class VisitorStatisticRepository : RepositoryBase<VisitorStatistic>, ITagRepository
{
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
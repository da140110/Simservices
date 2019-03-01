using System.Collections.Generic;
using System.Linq;
using SimServices.Data.Infrastructure;
using SimServices.Model.Models;

namespace SimServices.Data.Repositories
{
    public interface ISlideRepository : IRepository<Slide>
    {
        
    }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
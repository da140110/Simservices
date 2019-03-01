using System.Collections.Generic;
using System.Linq;
using SimServices.Data.Infrastructure;
using SimServices.Model.Models;

namespace SimServices.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    { 

    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
{
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
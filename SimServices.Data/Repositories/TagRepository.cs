using System.Collections.Generic;
using System.Linq;
using SimServices.Data.Infracstructure;
using SimServices.Model.Models;

namespace SimServices.Data.Repositories
{
    public interface ITagRepository
    { 

    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
{
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
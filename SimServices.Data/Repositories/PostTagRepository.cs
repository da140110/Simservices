using System.Collections.Generic;
using System.Linq;
using SimServices.Data.Infracstructure;
using SimServices.Model.Models;

namespace SimServices.Data.Repositories
{
    public interface IProductTagRepositoryIProductTagRepository
    {
        
    }

    public class PostTagRepository : RepositoryBase<PostTag>, IProductTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
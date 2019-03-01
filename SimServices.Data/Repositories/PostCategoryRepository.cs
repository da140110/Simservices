using System.Collections.Generic;
using System.Linq;
using SimServices.Data.Infrastructure;
using SimServices.Model.Models;

namespace SimServices.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
    {
        
    }

    public class PostCategoryRepository : RepositoryBase<PostCategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

    }
}
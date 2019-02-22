using SimServices.Data.Infracstructure;
using SimServices.Model.Models;

namespace SimServices.Data.Repositories
{
    public interface IFeedbackRepository
    {
    }

    public class FeedbackRepository : RepositoryBase<Feedback>, IFeedbackRepository
    {
        public FeedbackRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
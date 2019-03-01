namespace SimServices.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
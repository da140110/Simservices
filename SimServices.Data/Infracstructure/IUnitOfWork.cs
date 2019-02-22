namespace SimServices.Data.Infracstructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
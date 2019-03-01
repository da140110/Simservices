namespace SimServices.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private SimServicesDbContext dbContext;

        public SimServicesDbContext Init()
        {
            return dbContext ?? (dbContext = new SimServicesDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
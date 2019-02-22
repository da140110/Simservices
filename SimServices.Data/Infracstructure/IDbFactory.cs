using System;

namespace SimServices.Data.Infracstructure
{
    public interface IDbFactory : IDisposable
    {
        SimServicesDbContext Init();
    }
}
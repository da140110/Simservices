using System;

namespace SimServices.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        SimServicesDbContext Init();
    }
}
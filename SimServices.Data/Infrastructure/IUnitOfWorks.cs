using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimServices.Data.Infrastructure
{
    public interface IUnitOfWorks
    {
        void Commit();
    }
}

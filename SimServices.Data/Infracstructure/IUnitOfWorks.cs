﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimServices.Data.Infracstructure
{
    public interface IUnitOfWorks
    {
        void Commit();
    }
}

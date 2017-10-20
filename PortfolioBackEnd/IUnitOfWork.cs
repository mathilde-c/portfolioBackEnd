﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioBackEnd
{
    public interface IUnitOfWork
    {
        void Commit();
        void Dispose();

    }
}
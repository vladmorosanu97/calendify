using System;
using System.Collections.Generic;
using System.Text;

namespace Calendify.Application.Interfaces.Persistence
{
    public interface IUnitOfWork
    {
        void Save();
    }
}

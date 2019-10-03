using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Application.Interfaces.Persistence;

namespace Calendify.Persistence.Shared
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly IDatabaseContext _databaseContext;

        public UnitOfWork(IDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public void Save()
        {
            _databaseContext.Save();
        }
    }
}

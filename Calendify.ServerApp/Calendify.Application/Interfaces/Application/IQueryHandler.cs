using System;
using System.Collections.Generic;
using System.Text;

namespace Calendify.Application.Interfaces.Application
{
    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {
        TResult Handle(TQuery query);
    }
}

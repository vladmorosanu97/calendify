using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Domain.Notes;

namespace Calendify.Application.Interfaces.Persistence
{
    public interface INoteRepository: IRepository<Note>
    {
    }
}

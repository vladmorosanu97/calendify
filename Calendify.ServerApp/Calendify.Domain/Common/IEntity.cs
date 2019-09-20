using System;
using System.Collections.Generic;
using System.Text;

namespace Calendify.Domain.Common
{
    public interface IEntity
    {
        long Id { get; set; }
    }
}

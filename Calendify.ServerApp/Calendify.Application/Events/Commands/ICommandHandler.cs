using System;
using System.Collections.Generic;
using System.Text;
using CSharpFunctionalExtensions;

namespace Calendify.Application.Events.Commands
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        Result Handle(TCommand command);
    }
}

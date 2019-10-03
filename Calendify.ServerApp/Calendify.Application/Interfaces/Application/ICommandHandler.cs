using System;
using System.Collections.Generic;
using System.Text;
using CSharpFunctionalExtensions;

namespace Calendify.Application.Interfaces.Application
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        Result Handle(TCommand command);
    }
}

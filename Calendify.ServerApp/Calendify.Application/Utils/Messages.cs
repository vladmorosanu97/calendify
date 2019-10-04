using System;
using System.Collections.Generic;
using System.Text;
using Calendify.Application.Interfaces.Application;
using CSharpFunctionalExtensions;
using Microsoft.Extensions.DependencyInjection;

namespace Calendify.Application.Utils
{
    public sealed class Messages
    {
        private readonly IServiceProvider _serviceProvider;

        public Messages(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }


        public Result Dispatch(ICommand command)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                Type type = typeof(ICommandHandler<>);
                Type[] typeArgs = {command.GetType()};
                Type handlerType = type.MakeGenericType(typeArgs);

                dynamic handler = scope.ServiceProvider.GetService(handlerType);
                Result result = handler.Handle((dynamic) command);
                return result;
            }
        }

        public Result Dispatch<T>(IQuery<T> query)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                Type type = typeof(IQueryHandler<,>);
                Type[] typeArgs = { query.GetType(), typeof(T) };
                Type handlerType = type.MakeGenericType(typeArgs);

                dynamic handler = scope.ServiceProvider.GetService(handlerType);
                Result result = handler.Handle((dynamic)query);
                return result;
            }
        }
    }
}
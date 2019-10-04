using System;
using System.Collections.Generic;
using System.Text;
using CSharpFunctionalExtensions;

namespace Calendify.Application.Users.Commands
{
    public sealed class LastName: ValueObject
    {
        public string Value { get; }

        private LastName(string value)
        {
            Value = value;
        }

        public static Result<LastName> Create(Maybe<string> valueOrNothing)
        {
            return valueOrNothing.ToResult("Last name should not be empty")
                .Ensure(value => value.Length < 512, "First name is too long")
                .Map(value => new LastName(value));
        }

        public static explicit operator LastName(string value)
        {
            return Create(value).Value;
        }

        public static implicit operator string(LastName item)
        {
            return item.Value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}

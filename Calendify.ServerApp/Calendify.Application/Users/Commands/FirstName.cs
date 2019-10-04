using System;
using System.Collections.Generic;
using System.Text;
using CSharpFunctionalExtensions;

namespace Calendify.Application.Users.Commands
{
    public sealed class FirstName: ValueObject
    {
        public string Value { get; }

        private FirstName(string value)
        {
            Value = value;
        }

        public static Result<FirstName> Create(Maybe<string> valueOrNothing)
        {
            return valueOrNothing.ToResult("First name should not be empty")
                .Ensure(value => value.Length < 512, "First name is too long")
                .Map(value => new FirstName(value));
        }

        public static explicit operator FirstName(string value)
        {
            return Create(value).Value;
        }

        public static implicit operator string(FirstName item)
        {
            return item.Value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}

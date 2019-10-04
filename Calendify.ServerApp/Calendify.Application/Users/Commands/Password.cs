using System;
using System.Collections.Generic;
using System.Text;
using CSharpFunctionalExtensions;

namespace Calendify.Application.Users.Commands
{
    public sealed class Password: ValueObject
    {
        public string Value { get; }

        private Password(string value)
        {
            Value = value;
        }

        public static Result<Password> Create(Maybe<string> valueOrNothing)
        {
            return valueOrNothing.ToResult("Password should not be empty")
                .Ensure(value => value != string.Empty, "Password should not be empty")
                .Ensure(value => value.Length <= 256, "Password is too long")
                .Map(value => new Password(value));
        }

        public static explicit operator Password(string value)
        {
            return Create(value).Value;
        }

        public static implicit operator string(Password item)
        {
            return item.Value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}

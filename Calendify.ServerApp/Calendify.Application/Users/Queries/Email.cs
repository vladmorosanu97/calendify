using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;

namespace Calendify.Application.Users.Queries
{
    public sealed class Email: ValueObject
    {
        public string Value { get; }

        private Email(string value)
        {
            Value = value;
        }

        public static Result<Email> Create(Maybe<string> valueOrNothing)
        {
            return valueOrNothing.ToResult("Email should not be empty")
                .Ensure(value => value != string.Empty, "Email should not be empty")
                .Ensure(value => value.Length <= 256, "Email is too long")
                .Ensure(value => Regex.IsMatch(value, @"^(.+)@(.+)$"), "Email is invalid")
                .Map(value => new Email(value));
        }

        public static explicit operator Email(string value)
        {
            return Create(value).Value;
        }

        public static implicit operator string(Email item)
        {
            return item.Value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}

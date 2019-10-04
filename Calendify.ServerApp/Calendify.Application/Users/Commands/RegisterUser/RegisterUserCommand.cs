using Calendify.Application.Interfaces.Application;

namespace Calendify.Application.Users.Commands.RegisterUser
{
    public class RegisterUserCommand: ICommand
    {
        public FirstName FirstName { get; }
        public LastName LastName { get; }
        public Password Password { get; }
        public Email Email { get; }

        public RegisterUserCommand(FirstName firstName, LastName lastName, Email email, Password password)
        {
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

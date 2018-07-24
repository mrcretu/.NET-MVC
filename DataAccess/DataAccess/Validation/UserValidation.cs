using FluentValidation;

namespace DataAccess.Validation
{
    class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(user => user.Id).NotEmpty();
        }
    }
}

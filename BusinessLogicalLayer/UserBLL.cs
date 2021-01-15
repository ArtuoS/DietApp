using Entities;
using System;
using FluentValidation;

namespace BusinessLogicalLayer
{
    public class UserBLL : AbstractValidator<User>
    {
        public UserBLL()
        {
            RuleFor(a => a.First_Name).NotNull().Length(3, 40);
            RuleFor(b => b.Email).EmailAddress();
        }
    }
}

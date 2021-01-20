using Entities;
using FluentValidation;
using MVCPresentationLayer.Models.InsertModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPresentationLayer.Validators
{
    public class UserValidator : AbstractValidator<UserInsertViewModel>
    {
        public UserValidator()
        {
            RuleFor(a => a.First_Name).NotNull().Length(3, 40).WithMessage("O nome deve ter entre 3 e 40 caractéres.");
            RuleFor(a => a.Last_Name).NotNull().Length(3, 40).WithMessage("O sobrenome deve ter entre 3 e 40 caractéres.");
            RuleFor(b => b.Email).EmailAddress().NotNull().WithMessage("O e-mail inserido é inválido.");
        }
    }
}

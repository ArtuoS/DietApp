using Entities;
using System;
using FluentValidation;
using FluentValidation.Results;
using Entities.Factory;
using Entities.Interfaces;
using DataAcessLayer;
using System.Threading.Tasks;
using Common;

namespace BusinessLogicalLayer
{
    public class UserBLL : AbstractValidator<User>, IUserService
    {
        public UserBLL()
        {
            RuleFor(a => a.First_Name).NotNull().Length(3, 40).WithMessage("O nome deve ter entre 3 e 40 caractéres.");
            RuleFor(a => a.Last_Name).NotNull().Length(3, 40).WithMessage("O sobrenome deve ter entre 3 e 40 caractéres.");
            RuleFor(b => b.Email).EmailAddress().WithMessage("O e-mail inserido é inválido.");
            RuleFor(a => a.Weigth).NotNull().GreaterThan(1).WithMessage("O peso deve ser maior que 1.");
            RuleFor(a => a.Heigth).NotNull().WithMessage("A altura deve ser entre 0.01m e 2.51m."); //.GreaterThan(0.01).LessThan(2.51)
            RuleFor(a => a.Password).NotNull().Length(3, 100).WithMessage("A senha deve ter entre 3 e 100 caractéres");
        }

        UserDAL userDAL = new UserDAL();

        public async Task<Response> Insert(User item)
        {
            ValidationResult results = this.Validate(item);
            try
            {
                if (!results.IsValid)
                {
                    return ResponseFactory.ResponseErrorModel(results.Errors);
                }
                else
                {
                    item.ReplaceGenderWithNumber(item.Gender);
                    return await userDAL.Insert(item);
                }
            }
            catch (Exception ex)
            {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public async Task<Response> Update(User item)
        {
            ValidationResult results = this.Validate(item);
            try
            {
                if (!results.IsValid)
                {
                    return ResponseFactory.ResponseErrorModel(results.Errors);
                }
                else
                {
                    return await userDAL.Update(item);
                }
            }
            catch (Exception ex)
            {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public async Task<Response> Delete(int id)
        {
            try
            {
                return await userDAL.Delete(id);
            }
            catch (Exception ex)
            {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public async Task<QueryResponse<User>> GetAll()
        {
            try
            {
                return await userDAL.GetAll();
            }
            catch (Exception ex)
            {
                return ResponseFactory.QueryResponseExceptionModel<User>(ex);
            }
        }

        public async Task<SingleResponse<User>> GetById(int id)
        {
            try
            {
                return await userDAL.GetById(id);
            }
            catch (Exception ex)
            {
                return ResponseFactory.SingleResponseExceptionModel<User>(ex);
            }
        }

        public async Task<Response> Disable(int id)
        {
            try
            {
                return await userDAL.Disable(id);
            }
            catch (Exception ex)
            {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }
    }
}
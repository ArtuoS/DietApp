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
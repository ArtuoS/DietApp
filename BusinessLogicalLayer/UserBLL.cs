﻿using Entities;
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
            return await userDAL.Delete(id);
        }

        public Task<QueryResponse<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SingleResponse<User>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Disable(int id)
        {
            throw new NotImplementedException();
        }

    }
}
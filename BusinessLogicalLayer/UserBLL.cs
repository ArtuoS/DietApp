﻿using Entities;
using System;
using FluentValidation;
using Common;
using FluentValidation.Results;
using Common.Factory;
using Common.Interfaces;
using DataAcessLayer;

namespace BusinessLogicalLayer
{
    public class UserBLL : AbstractValidator<User>, IUserService
    {
        /*
        public UserBLL()
        {
            RuleFor(a => a.First_Name).NotNull().Length(3, 40).WithMessage("O nome deve ter entre 3 e 40 caractéres.");
            RuleFor(b => b.Email).EmailAddress().WithMessage("O e-mail inserido é inválido.");
        }
        */

        //UserBLL userBLL = new UserBLL();
        UserDAL userDAL = new UserDAL();

        public Response Delete(int id)
        {
            throw new NotImplementedException();
        }

        public QueryResponse<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public SingleResponse<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Response Insert(User item)
        {
            Response response = new Response();
            //ValidationResult results = userBLL.Validate(item);
            try
            {
                return userDAL.Insert(item);
                /*
                if (results.IsValid)
                {
                    return userDAL.Insert(item);
                }
                else
                {
                    return ResponseFactory.ResponseErrorModel(results.Errors);
                }
                */
            }
            catch (Exception ex)
            {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public Response Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}

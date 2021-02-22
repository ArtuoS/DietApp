﻿using Entities;
using System;
using FluentValidation;
using FluentValidation.Results;
using Entities.Factory;
using Entities.Interfaces;
using DataAcessLayer;
using System.Threading.Tasks;
using Common;
using System.Text.RegularExpressions;
using System.Text;

namespace BusinessLogicalLayer
{
    public class UserBLL : AbstractValidator<User>, IUserService
    {
        public UserBLL()
        {
            RuleFor(a => a.First_Name).NotNull().Length(3, 40).WithMessage("O nome deve ter entre 3 e 40 caractéres.");
            RuleFor(a => a.Last_Name).NotNull().Length(3, 40).WithMessage("O sobrenome deve ter entre 3 e 40 caractéres.");
            RuleFor(b => b.Email).EmailAddress().WithMessage("O e-mail inserido é inválido.");
            RuleFor(a => a.Weight).NotNull().GreaterThan(1).WithMessage("O peso deve ser maior que 1.");
            RuleFor(a => a.Height).NotNull().WithMessage("A altura deve ser entre 0.01m e 2.51m."); //.GreaterThan(0.01).LessThan(2.51)
            RuleFor(a => a.Password).NotNull().Length(3, 100).WithMessage("A senha deve ter entre 3 e 100 caractéres");
        }

        UserDAL userDAL = new UserDAL();

        public async Task<Response> Insert(User item)
        {
            ValidationResult results = this.Validate(item);

            item.Password = EncryptPassword(item.Password);

            try
            {
                if (!results.IsValid)
                {
                    return ResponseFactory.ResponseErrorModel(results.Errors);
                }
                else
                {
                    item.CalculateIMC();
                    item.CalculateGET();
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
            try
            {
                SingleResponse<User> user = await this.GetById(item.ID);
                user.Data.First_Name = item.First_Name;
                user.Data.Last_Name = item.Last_Name;
                user.Data.Gender = item.Gender;
                user.Data.Email = item.Email;
                user.Data.Weight = item.Weight;
                user.Data.Height = item.Height;
                user.Data.BodyFat = item.BodyFat;

                ValidationResult results = this.Validate(user.Data);

                if (!results.IsValid)
                {
                    return ResponseFactory.ResponseErrorModel(results.Errors);
                }
                else
                {
                    return await userDAL.Update(user.Data);
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

        public async Task<SingleResponse<User>> Authenticate(string email, string senha)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            senha = this.EncryptPassword(senha);

            try
            {
                if (match.Success && (senha.Length >= 3 && senha.Length < 100))
                    return await userDAL.Authenticate(email, senha);
                return ResponseFactory.SingleResponseNotFoundException<User>();
            }
            catch (Exception ex)
            {
                return ResponseFactory.SingleResponseExceptionModel<User>(ex);
            }
        }

        public string EncryptPassword(string password)
        {
            var encodedValue = Encoding.UTF8.GetBytes(password);
            var encryptedPassword = System.Security.Cryptography.MD5.Create().ComputeHash(encodedValue);

            var sb = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                sb.Append(caracter.ToString("X2"));
            }

            return sb.ToString();
        }

        public async Task<QueryResponse<Food>> GetFoodsFromRestrictionByUserID(int id)
        {
            try
            {
                return await userDAL.GetFoodsFromRestrictionByUserID(id);
            }
            catch (Exception ex)
            {
                return ResponseFactory.QueryResponseExceptionModel<Food>(ex);
            }
        }
    }
}
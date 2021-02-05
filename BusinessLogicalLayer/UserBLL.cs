using Entities;
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

namespace BusinessLogicalLayer {
    public class UserBLL : AbstractValidator<User>, IUserService {
        public UserBLL() {
            RuleFor(a => a.First_Name).NotNull().Length(3, 40).WithMessage("O nome deve ter entre 3 e 40 caractéres.");
            RuleFor(a => a.Last_Name).NotNull().Length(3, 40).WithMessage("O sobrenome deve ter entre 3 e 40 caractéres.");
            RuleFor(b => b.Email).EmailAddress().WithMessage("O e-mail inserido é inválido.");
            RuleFor(a => a.Weight).NotNull().GreaterThan(1).WithMessage("O peso deve ser maior que 1.");
            RuleFor(a => a.Height).NotNull().WithMessage("A altura deve ser entre 0.01m e 2.51m."); //.GreaterThan(0.01).LessThan(2.51)
            RuleFor(a => a.Password).NotNull().Length(3, 100).WithMessage("A senha deve ter entre 3 e 100 caractéres");
        }

        UserDAL userDAL = new UserDAL();

        public async Task<Response> Insert(User item) {
            ValidationResult results = this.Validate(item);

            item.Password = EncryptPassword(item.Password);

            try {
                if (!results.IsValid) {
                    return ResponseFactory.ResponseErrorModel(results.Errors);
                } else {
                    item.CalculateGET();
                    item.ReplaceGenderWithNumber(item.Gender);
                    return await userDAL.Insert(item);
                }
            } catch (Exception ex) {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public async Task<Response> Update(User item) {
            try {
                ValidationResult results = this.Validate(item);

                if (!results.IsValid) {
                    return ResponseFactory.ResponseErrorModel(results.Errors);
                } else {
                    return await userDAL.Update(item);
                }
            } catch (Exception ex) {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public async Task<Response> Delete(int id) {
            try {
                return await userDAL.Delete(id);
            } catch (Exception ex) {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public async Task<QueryResponse<User>> GetAll() {
            try {
                return await userDAL.GetAll();
            } catch (Exception ex) {
                return ResponseFactory.QueryResponseExceptionModel<User>(ex);
            }
        }

        public async Task<SingleResponse<User>> GetById(int id) {
            try {
                return await userDAL.GetById(id);
            } catch (Exception ex) {
                return ResponseFactory.SingleResponseExceptionModel<User>(ex);
            }
        }

        public async Task<Response> Disable(int id) {
            try {
                return await userDAL.Disable(id);
            } catch (Exception ex) {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public async Task<SingleResponse<User>> Authenticate(string email, string senha) {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            senha = this.EncryptPassword(senha);

            try {
                if (match.Success && (senha.Length >= 3 && senha.Length < 100))
                    return await userDAL.Authenticate(email, senha);
                return ResponseFactory.SingleResponseNotFoundException<User>();
            } catch (Exception ex) {
                return ResponseFactory.SingleResponseExceptionModel<User>(ex);
            }
        }

        public string EncryptPassword(string password) {
            var encodedValue = Encoding.UTF8.GetBytes(password);
            var encryptedPassword = System.Security.Cryptography.MD5.Create().ComputeHash(encodedValue);

            var sb = new StringBuilder();
            foreach (var caracter in encryptedPassword) {
                sb.Append(caracter.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
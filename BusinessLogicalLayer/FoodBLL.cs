using Entities;
using Entities.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Common;
using DataAcessLayer;
using Entities.Factory;
using FluentValidation.Results;

namespace BusinessLogicalLayer
{
    public class FoodBLL : AbstractValidator<Food>, IFoodService
    {
        public FoodBLL()
        {
            RuleFor(a => a.Food_Name).NotNull().Length(3, 40).WithMessage("O nome deve conter entre 3 e 40 caracteres");
        }

        FoodDAL foodDAL = new FoodDAL();

        public async Task<Response> Insert(Food item)
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
                    return await foodDAL.Insert(item);
                }
            }
            catch (Exception ex)
            {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public async Task<Response> Update(Food item)
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
                    return await foodDAL.Update(item);
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
                return await foodDAL.Delete(id);
            }
            catch (Exception ex)
            {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public async Task<Response> Disable(int id)
        {
            try
            {
                return await foodDAL.Disable(id);
            }
            catch (Exception ex)
            {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public async Task<QueryResponse<Food>> GetAll()
        {
            try
            {
                return await foodDAL.GetAll();
            }
            catch (Exception ex)
            {
                return ResponseFactory.QueryResponseExceptionModel<Food>(ex);
            }
        }

        public async Task<SingleResponse<Food>> GetById(int id)
        {
            try
            {
                return await foodDAL.GetById(id);
            }
            catch (Exception ex)
            {
                return ResponseFactory.SingleResponseExceptionModel<Food>(ex);
            }
        }

        public async Task<SingleResponse<Food>> GetByName(Food name)
        {
            try
            {
                return await foodDAL.GetByName(name);
            }
            catch (Exception ex)
            {
                return ResponseFactory.SingleResponseExceptionModel<Food>(ex);
            }
        }

        public async Task<QueryResponse<Food>> GetByCategoryId(int id)
        {
            try
            {
                return await foodDAL.GetByCategoryId(id);
            }
            catch (Exception ex)
            {
                return ResponseFactory.QueryResponseExceptionModel<Food>(ex);
            }
        }
    }
}

using Common;
using DataAcessLayer;
using Entities;
using Entities.Factory;
using Entities.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class Food_CategoryBLL : AbstractValidator<FoodCategory>, IFood_CategoryService
    {
        public Food_CategoryBLL()
        {
            RuleFor(a => a.Name).NotNull().Length(3, 50).WithMessage("O nome deve ter entre 3 e 50 caractéres.");
        }
        Food_CategoryDAL food_categoryDAL = new Food_CategoryDAL();

        public async Task<Response> Delete(int id)
        {
            try
            {
                return await food_categoryDAL.Delete(id);
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
                return await food_categoryDAL.Disable(id);
            }
            catch (Exception ex)
            {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public async Task<QueryResponse<FoodCategory>> GetAll()
        {
            try
            {
                return await food_categoryDAL.GetAll();
            }
            catch (Exception ex)
            {
                return ResponseFactory.QueryResponseExceptionModel<FoodCategory>(ex);
            }
        }

        public async Task<SingleResponse<FoodCategory>> GetById(int id)
        {
            try
            {
                return await food_categoryDAL.GetById(id);
            }
            catch (Exception ex)
            {
                return ResponseFactory.SingleResponseExceptionModel<FoodCategory>(ex);
            }
        }

        public async Task<SingleResponse<FoodCategory>> GetByName(string name)
        {
            try
            {
                return await food_categoryDAL.GetByName(name);
            }
            catch (Exception ex)
            {
                return ResponseFactory.SingleResponseExceptionModel<FoodCategory>(ex);
            }
        }

        public async Task<Response> Insert(FoodCategory item)
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
                    return await food_categoryDAL.Insert(item);
                }
            }
            catch (Exception ex)
            {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public async Task<Response> Update(FoodCategory item)
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
                    return await food_categoryDAL.Update(item);
                }
            }
            catch (Exception ex)
            {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }
    }
}

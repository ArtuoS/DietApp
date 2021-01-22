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
   public class MealBLL : AbstractValidator<Meal>, IMealService
    {
        public MealBLL()
        {
            RuleFor(a => a.Name).NotNull().Length(3, 50).WithMessage("O nome deve ter entre 3 e 50 caractéres.");
        }

        MealDAL mealDAL = new MealDAL();

        public async Task<Response> Insert(Meal item)
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
                    return await mealDAL.Insert(item);
                }
            }
            catch (Exception ex)
            {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public async Task<Response> Disable(int id)
        {
            return await mealDAL.Disable(id);
        }

        public async Task<QueryResponse<Meal>> GetAll()
        {
            try
            {
                return await mealDAL.GetAll();
            }
            catch (Exception ex)
            {
                return ResponseFactory.QueryExceptionModel<Meal>(ex);
            }
        }

        public async Task<SingleResponse<Meal>> GetById(int id)
        {
            return await mealDAL.GetById(id);
        }

        public async Task<Response> Delet(Meal id)
        {
            throw new NotImplementedException();
            //return await mealDAL.Delete(id);
        }

        public async Task<Response> Update(Meal item)
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
                    return await mealDAL.Update(item);
                }
            }
            catch (Exception ex)
            {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public SingleResponse<Meal> GetByName(Meal item)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

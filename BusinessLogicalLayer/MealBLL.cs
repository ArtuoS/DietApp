using Common;
using DataAcessLayer;
using Entities;
using Entities.Enums;
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

        public async Task<SingleResponse<Meal>> GetByName(Meal name)
        {
            try
            {
                return await mealDAL.GetByName(name);
            }
            catch (Exception ex)
            {
                return ResponseFactory.SingleResponseExceptionModel<Meal>(ex);
            }
        }

        public async Task<SingleResponse<int>> Insert(Meal item)
        {
            ValidationResult results = this.Validate(item);
            try
            {
                if (!results.IsValid)
                {
                    return ResponseFactory.SingleResponseNotFoundException<int>();
                }
                else
                {
                    return await mealDAL.Insert(item);
                }
            }
            catch (Exception ex)
            {
                return ResponseFactory.SingleResponseExceptionModel<int>(ex);
            }
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

        public async Task<Response> Delete(int id)
        {

            try
            {
                return await mealDAL.Delete(id);
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
                return await mealDAL.Disable(id);
            }
            catch (Exception ex)
            {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public async Task<QueryResponse<Meal>> GetAll()
        {
            try
            {
                return await mealDAL.GetAll();
            }
            catch (Exception ex)
            {
                return ResponseFactory.QueryResponseExceptionModel<Meal>(ex);
            }
        }

        public async Task<SingleResponse<Meal>> GetById(int id)
        {
            try
            {
                return await mealDAL.GetById(id);
            }
            catch (Exception ex)
            {
                return ResponseFactory.SingleResponseExceptionModel<Meal>(ex);
            }
        }

        public async Task<QueryResponse<Meal>> GetByCategory(Meal_Category category)
        {
            try
            {
                return await mealDAL.GetByCategory(category);
            }
            catch (Exception ex)
            {
                return ResponseFactory.QueryResponseExceptionModel<Meal>(ex);
            }
        }

        public async Task<QueryResponse<FoodAmountPerMeal>> GetMealFoodsById(int id)
        {
            try
            {
                return await mealDAL.GetMealFoodsById(id);
            }
            catch (Exception ex)
            {
                return ResponseFactory.QueryResponseExceptionModel<FoodAmountPerMeal>(ex);
            }
        }
        

    }
}

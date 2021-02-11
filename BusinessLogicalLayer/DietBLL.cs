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
    public class DietBLL : AbstractValidator<Diet>, IDietService
    {
        private readonly IMealService mealService;
        public DietBLL()
        {
            RuleFor(a => a.Name).NotNull().Length(3, 50).WithMessage("O nome deve ter entre 3 e 50 caractéres.");
        }
        DietDAL dietDAL = new DietDAL();

        public async Task<SingleResponse<Diet>> GetByName(Diet name)
        {
            try
            {
                return await dietDAL.GetByName(name);
            }
            catch (Exception ex)
            {
                return ResponseFactory.SingleResponseExceptionModel<Diet>(ex);
            }
        }

        public async Task<Response> Insert(Diet item)
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
                    return await dietDAL.Insert(item);
                }
            }
            catch (Exception ex)
            {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }
        public async Task<Response> Update(Diet item)
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
                    return await dietDAL.Update(item);
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
                return await dietDAL.Delete(id);
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
                return await dietDAL.Disable(id);
            }
            catch (Exception ex)
            {
                return ResponseFactory.ResponseExceptionModel(ex);
            }
        }

        public async Task<QueryResponse<Diet>> GetAll()
        {
            try
            {
                return await dietDAL.GetAll();
            }
            catch (Exception ex)
            {
                return ResponseFactory.QueryResponseExceptionModel<Diet>(ex);
            }
        }

        public async Task<SingleResponse<Diet>> GetById(int id)
        {
            try
            {
                return await dietDAL.GetById(id);
            }
            catch (Exception ex)
            {
                return ResponseFactory.SingleResponseExceptionModel<Diet>(ex);
            }
        }

        public async Task<SingleResponse<Diet>> GetByDate(DateTime date)
        {
            try
            {
                return await dietDAL.GetByDate(date);
            }
            catch (Exception ex)
            {
                return ResponseFactory.SingleResponseExceptionModel<Diet>(ex);
            }
        }
        public async Task<SingleResponse<Diet>> GenareteDiet(User user)
        {
            try
            {
                double daily_calories_breakfast = user.Daily_Calories / 0.3;
                double daily_carbohydrates_breakfast = user.Daily_Carbohydrates / 0.3;
                double daily_proteins_breakfast = user.Daily_Protein / 0.3;
                double daily_lipids_breakfast = user.Daily_Fats / 0.3;

                double daily_calories_lunch = user.Daily_Calories / 0.4;
                double daily_carbohydrates_lunch = user.Daily_Carbohydrates / 0.4;
                double daily_proteins_lunch = user.Daily_Protein / 0.4;
                double daily_lipids_lunch = user.Daily_Fats / 0.4;

                double daily_calories_dinner = user.Daily_Calories / 0.3;
                double daily_carbohydrates_dinner = user.Daily_Carbohydrates / 0.3;
                double daily_proteins_dinner = user.Daily_Protein / 0.3;
                double daily_lipids_dinner = user.Daily_Fats / 0.3;

                QueryResponse<Meal> response_meals_breakfast = await mealService.GetByCategory(Meal_Category.Café_da_manhã);
                QueryResponse<Meal> response_meals_lunch = await mealService.GetByCategory(Meal_Category.Almoço);
                QueryResponse<Meal> respnse_meals_dinner = await mealService.GetByCategory(Meal_Category.Jantar);


                Diet diet = new Diet();

                List<Meal> naopode= new List<Meal>();

                List<Meal> breakfast_meals = new List<Meal>();
                List<Meal> lunch_meals = new List<Meal>();
                List<Meal> dinner_meals = new List<Meal>();

                foreach (Meal meal in response_meals_breakfast.Data)
                {
                    foreach (FoodAmountPerMeal meal_food in meal.Foods)
                    {
                        foreach (Food restriction_food in user.Restriction.Foods)
                        {
                            if (restriction_food == meal_food.Food)
                            {
                                naopode.Add(meal);
                            }
                        
                        }
                    }
                    
                }
                foreach (Meal meal_restriction in naopode)
                {
                    foreach (Meal meal_breakfast_final in response_meals_breakfast.Data)
                    { 
                        breakfast_meals.Remove(meal_restriction);
                    }
                }
                foreach (Meal item in breakfast_meals)
                {
                    if (item.Total_Calories == daily_calories_breakfast || item.Total_Calories == (daily_calories_breakfast + 200) || item.Total_Calories == (daily_calories_breakfast - 200))
                    {
                        diet.Meals.Add(item);
                    }
                }

                SingleResponse<Diet> dietResponse = new SingleResponse<Diet>();
                dietResponse.Data = diet;
                dietResponse.Success = true;
                return dietResponse;
            }
            catch (Exception ex)
            {
                return ResponseFactory.SingleResponseExceptionModel<Diet>(ex);
            }
        }
    }
}

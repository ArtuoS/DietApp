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
        private readonly IUserService userService;
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
                SingleResponse<Diet> result = await dietDAL.GetByDate(date);
                return result;
            }
            catch (Exception ex)
            {
                return ResponseFactory.SingleResponseExceptionModel<Diet>(ex);
            }
        }
        public async Task<SingleResponse<Diet>> GenareteDiet(int id)
        {
            User user = userService.GetById(id).Result.Data;
            try
            {
                double breakfastCalories = user.Daily_Calories / 0.3;
                double breakfastCarbohydrates = user.Daily_Carbohydrates / 0.3;
                double breakfastProteins = user.Daily_Protein / 0.3;
                double breakfastLipids = user.Daily_Fats / 0.3;

                double lunchCalories = user.Daily_Calories / 0.4;
                double lunchCarbohydrates = user.Daily_Carbohydrates / 0.4;
                double lunchProteins = user.Daily_Protein / 0.4;
                double lunchLipids = user.Daily_Fats / 0.4;

                double dinnerCalories = user.Daily_Calories / 0.3;
                double dinnerCarbohydrates = user.Daily_Carbohydrates / 0.3;
                double dinnerProteins = user.Daily_Protein / 0.3;
                double dinnerLipids = user.Daily_Fats / 0.3;

                QueryResponse<Meal> breakfastMeals = await mealService.GetByCategory(Meal_Category.Café_da_manhã);
                QueryResponse<Meal> lunchMeals = await mealService.GetByCategory(Meal_Category.Almoço);
                QueryResponse<Meal> dinnerMeals = await mealService.GetByCategory(Meal_Category.Jantar);

                Diet diet = new Diet();

                List<Meal> restrictedMeals = new List<Meal>();

                List<Meal> filteredBreakfastMeals = new List<Meal>();
                List<Meal> filteredLunchMeals = new List<Meal>();
                List<Meal> filteredDinnerMeals = new List<Meal>();

                foreach (Meal meal in breakfastMeals.Data)
                {
                    foreach (FoodAmountPerMeal foodAmount in meal.Foods)
                    {
                        foreach (Food food in user.Restriction.Foods)
                        {
                            if (food == foodAmount.Food)
                            {
                                restrictedMeals.Add(meal);
                            }
                        }
                    }
                }

                foreach (Meal meal in restrictedMeals)
                {
                    foreach (Meal breakfastMeal in breakfastMeals.Data)
                    {
                        filteredBreakfastMeals.Remove(breakfastMeal);
                    }

                    foreach (Meal lunchMeal in lunchMeals.Data)
                    {
                        filteredLunchMeals.Remove(lunchMeal);
                    }

                    foreach (Meal dinnerMeal in lunchMeals.Data)
                    {
                        filteredDinnerMeals.Remove(dinnerMeal);
                    }
                }

                foreach (Meal item in filteredBreakfastMeals)
                {
                    if (item.Total_Calories == breakfastCalories || item.Total_Calories == (breakfastCalories + 200) || item.Total_Calories == (breakfastCalories - 200))
                    {
                        diet.Meals.Add(item);
                    }
                }

                foreach (Meal item in filteredLunchMeals)
                {
                    if (item.Total_Calories == breakfastCalories || item.Total_Calories == (breakfastCalories + 200) || item.Total_Calories == (breakfastCalories - 200))
                    {
                        diet.Meals.Add(item);
                    }
                }

                foreach (Meal item in filteredDinnerMeals)
                {
                    if (item.Total_Calories == breakfastCalories || item.Total_Calories == (breakfastCalories + 200) || item.Total_Calories == (breakfastCalories - 200))
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

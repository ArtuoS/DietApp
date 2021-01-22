using Common;
using Entities;
using Entities.Factory;
using Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class MealDAL : IMealService
    {
        public async Task<Response> Delete(int id)
        {
            Meal meal = new Meal();
            meal.ID = id;

            using (DietDB db = new DietDB())
            {
                db.Entry(meal).State = EntityState.Deleted;
                await db.SaveChangesAsync();
            }

            return ResponseFactory.ResponseSuccessModel();
        }

        public async Task<Response> Disable(int id)
        {
            using (DietDB db = new DietDB())
            {
                Meal meal = await db.Meals.FirstOrDefaultAsync(u => u.ID == id);
                if (meal != null)
                {
                    meal.Status = false;
                    await db.SaveChangesAsync();
                    return ResponseFactory.ResponseSuccessModel();
                }
                return ResponseFactory.ResponseNotFoundException();
            }
        }
        public async Task<QueryResponse<Meal>> GetAll()
        {
            QueryResponse<Meal> response = new QueryResponse<Meal>();

            using (DietDB db = new DietDB())
            {
                List<Meal> meals = await db.Meals.ToListAsync();
                response.Data = meals;
            }

            return response;
        }

        public async Task<SingleResponse<Meal>> GetById(int id)
        {
            SingleResponse<Meal> response = new SingleResponse<Meal>();

            using (DietDB db = new DietDB())
            {
                Meal meal = await db.Meals.FirstOrDefaultAsync(w => w.ID == id);
                response.Data = meal;
            }

            return response;
        }

        public async Task<SingleResponse<Food>> GetByName(Meal item)
        {
            throw new NotImplementedException();
        }

        public async Task<Response> Insert(Meal item)
        {
            using (DietDB db = new DietDB())
            {
                db.Meals.Add(item);
                await db.SaveChangesAsync();
            }

            return ResponseFactory.ResponseSuccessModel();
        }

        public async Task<Response> Update(Meal item)
        {
            using (DietDB db = new DietDB())
            {
                db.Entry(item).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }

            return ResponseFactory.ResponseSuccessModel();
        }

        SingleResponse<Meal> IMealService.GetByName(Meal item)
        {
            throw new NotImplementedException();
        }
    }
}

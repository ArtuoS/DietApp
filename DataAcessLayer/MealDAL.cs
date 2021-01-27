﻿using Common;
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
            Meal user = new Meal();
            user.ID = id;

            using (DietDB db = new DietDB())
            {
                if (user != null)
                {
                    db.Entry(user).State = EntityState.Deleted;
                    await db.SaveChangesAsync();
                    return ResponseFactory.ResponseSuccessModel();
                }
                return ResponseFactory.SingleResponseNotFoundException<User>();
            }
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
                if (meal != null)
                {
                    response.Data = meal;
                    return ResponseFactory.SingleResponseSuccessModel<Meal>(meal);
                }
                return ResponseFactory.SingleResponseNotFoundException<Meal>();
            }

        }

        public async Task<SingleResponse<Meal>> GetByName(Meal item)
        {
            SingleResponse<Meal> response = new SingleResponse<Meal>();

            string name = item.Name;

            using (DietDB db = new DietDB())
            {
                Meal meal = await db.Meals.FirstOrDefaultAsync(w => w.Name == name);
                response.Data = meal;
            }

            return response;
        }

        public async Task<Response> Insert(Meal item)
        {
            using(DietDB db = new DietDB())
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
    }
}

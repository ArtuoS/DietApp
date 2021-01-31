using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Entities.Interfaces;
using Entities.Factory;

namespace DataAcessLayer
{
    public class FoodDAL : IFoodService
    {
        public async Task<Response> Delete(int id)
        {
            Food food = new Food();
            food.ID = id;

            using (DietDB db = new DietDB())
            {
                db.Entry(food).State = EntityState.Deleted;
                await db.SaveChangesAsync();
            }

            return ResponseFactory.ResponseSuccessModel();
        }

        public async Task<Response> Disable(int id)
        {
            using (DietDB db = new DietDB())
            {
                Food food = await db.Foods.FirstOrDefaultAsync(u => u.ID == id);
                if (food != null)
                {
                    food.Status = false;
                    await db.SaveChangesAsync();
                    return ResponseFactory.ResponseSuccessModel();
                }
                return ResponseFactory.ResponseNotFoundException();
            }
        }

        public async Task<QueryResponse<Food>> GetAll()
        {
            QueryResponse<Food> response = new QueryResponse<Food>();

            using (DietDB db = new DietDB())
            {
                List<Food> foods = await db.Foods.ToListAsync();
                response.Data = foods;
                return ResponseFactory.QueryResponseSuccessModel<Food>(foods);
            }
            return ResponseFactory.QueryResponseNotFoundException<Food>();
        }

        public async Task<SingleResponse<Food>> GetById(int id)
        {
            SingleResponse<Food> response = new SingleResponse<Food>();

            using (DietDB db = new DietDB())
            {
                Food food = db.Foods.First(w => w.ID == id);
                response.Data = food;
                await db.SaveChangesAsync();
            }

            return response;
        }

        public async Task<SingleResponse<Food>> GetByName(Food item)
        {
            SingleResponse<Food> response = new SingleResponse<Food>();

            string name = item.Food_Name;

            using (DietDB db = new DietDB())
            {
                Food food = await db.Foods.FirstOrDefaultAsync(w => w.Food_Name == name);
                if (food != null)
                {
                    response.Data = food;
                    return ResponseFactory.SingleResponseSuccessModel<Food>(food);
                }
                return ResponseFactory.SingleResponseNotFoundException<Food>();
            }
        }

        public async Task<QueryResponse<Food>> GetByCategoryId(int id)
        {
            QueryResponse<Food> response = new QueryResponse<Food>();

            using (DietDB db = new DietDB())
            {
                List<Food> foods = await db.Foods.Where(c => c.Category.ID == id).ToListAsync();
                response.Data = foods;
                return ResponseFactory.QueryResponseSuccessModel<Food>(foods);
            }
            
        }

        public async Task<Response> Insert(Food item)
        {
            using (DietDB db = new DietDB())
            {
                db.Foods.Add(item);
                await db.SaveChangesAsync();
            }

            return ResponseFactory.ResponseSuccessModel();
        }

        public async Task<Response> Update(Food item)
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

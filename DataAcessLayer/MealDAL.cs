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
    public class MealDAL : IFoodService
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
            throw new NotImplementedException();
        }

        public async Task<QueryResponse<Food>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<SingleResponse<Food>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<SingleResponse<Food>> GetByName(Food item)
        {
            throw new NotImplementedException();
        }

        public async Task<Response> Insert(Food item)
        {
            throw new NotImplementedException();
        }

        public async Task<Response> Update(Food item)
        {
            throw new NotImplementedException();
        }

        SingleResponse<Food> IFoodService.GetByName(Food item)
        {
            throw new NotImplementedException();
        }
    }
}

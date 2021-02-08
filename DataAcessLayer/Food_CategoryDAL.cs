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
    public class Food_CategoryDAL : IFood_CategoryService
    {
        public async Task<Response> Delete(int id)
        {
            FoodCategory food_Category = new FoodCategory();
            food_Category.ID = id;

            using (DietDB db = new DietDB())
            {
                if (food_Category != null)
                {
                    db.Entry(food_Category).State = EntityState.Deleted;
                    await db.SaveChangesAsync();
                    return ResponseFactory.ResponseSuccessModel();
                }
                return ResponseFactory.SingleResponseNotFoundException<FoodCategory>();
            }
        }

        public async Task<Response> Disable(int id)
        {
            using (DietDB db = new DietDB())
            {
                FoodCategory food_Category = await db.Categories.FirstOrDefaultAsync(u => u.ID == id);
                if (food_Category != null)
                {
                    //food_Category.SetStatus(false);
                    await db.SaveChangesAsync();
                    return ResponseFactory.ResponseSuccessModel();
                }
                return ResponseFactory.ResponseNotFoundException();
            }
        }

        public async Task<QueryResponse<FoodCategory>> GetAll()
        {
            QueryResponse<FoodCategory> response = new QueryResponse<FoodCategory>();

            using (DietDB db = new DietDB())
            {
                List<FoodCategory> food_Categories = await db.Categories.ToListAsync();
                if (food_Categories != null)
                {
                    response.Data = food_Categories;
                    return ResponseFactory.QueryResponseSuccessModel(food_Categories);
                }
                return ResponseFactory.QueryResponseNotFoundException<FoodCategory>();
            }
        }

        public Task<SingleResponse<FoodCategory>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SingleResponse<FoodCategory>> GetByName(string nome)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Insert(FoodCategory item)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Update(FoodCategory item)
        {
            throw new NotImplementedException();
        }
    }
}

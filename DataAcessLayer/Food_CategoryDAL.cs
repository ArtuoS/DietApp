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
            Food_Category food_Category = new Food_Category();
            food_Category.ID = id;

            using (DietDB db = new DietDB())
            {
                if (food_Category != null)
                {
                    db.Entry(food_Category).State = EntityState.Deleted;
                    await db.SaveChangesAsync();
                    return ResponseFactory.ResponseSuccessModel();
                }
                return ResponseFactory.SingleResponseNotFoundException<Food_Category>();
            }
        }

        public async Task<Response> Disable(int id)
        {
            using (DietDB db = new DietDB())
            {
                /*Food_Category food_Category = await db.Categories.FirstOrDefaultAsync(u => u.ID == id);
                if (food_Category != null)
                {
                    food_Category.SetStatus(false);
                    await db.SaveChangesAsync();
                    return ResponseFactory.ResponseSuccessModel();
                }*/
                return ResponseFactory.ResponseNotFoundException();
            }
        }

        public async Task<QueryResponse<Food_Category>> GetAll()
        {
            QueryResponse<Food_Category> response = new QueryResponse<Food_Category>();

            using (DietDB db = new DietDB())
            {
                List<Food_Category> food_Categories = await db.Categories.ToListAsync();
                if (food_Categories != null)
                {
                    response.Data = food_Categories;
                    return ResponseFactory.QueryResponseSuccessModel(food_Categories);
                }
                return ResponseFactory.QueryResponseNotFoundException<Food_Category>();
            }
        }

        public Task<SingleResponse<Food_Category>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SingleResponse<Food_Category>> GetByName(string nome)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Insert(Food_Category item)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Update(Food_Category item)
        {
            throw new NotImplementedException();
        }
    }
}

using Common;
using Entities;
using Entities.Factory;
using Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DataAcessLayer
{
    public class DietDAL : IDietService
    {
        public async Task<Response> Delete(int id)
        {
            Diet diet = new Diet();
            diet.ID = id;

            using (DietDB db = new DietDB())
            {
                if (diet != null)
                {
                    db.Entry(diet).State = EntityState.Deleted;
                    await db.SaveChangesAsync();
                    return ResponseFactory.ResponseSuccessModel();
                }
                return ResponseFactory.SingleResponseNotFoundException<Diet>();
            }
        }

        public async Task<Response> Disable(int id)
        {
            using (DietDB db = new DietDB())
            {
                Diet diet = await db.Diets.FirstOrDefaultAsync(u => u.ID == id);
                if (diet != null)
                {
                    diet.SetStatus(false);
                    await db.SaveChangesAsync();
                    return ResponseFactory.ResponseSuccessModel();
                }
                return ResponseFactory.ResponseNotFoundException();
            }
        }

        public Task<SingleResponse<Diet>> GenareteDiet(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<QueryResponse<Diet>> GetAll()
        {
            QueryResponse<Diet> response = new QueryResponse<Diet>();

            using (DietDB db = new DietDB())
            {
                List<Diet> diets = await db.Diets.Where(a => a.Status).ToListAsync();
                if (diets != null)
                {
                    response.Data = diets;
                    return ResponseFactory.QueryResponseSuccessModel(diets);
                }
                return ResponseFactory.QueryResponseNotFoundException<Diet>();
            }
        }

        public async Task<SingleResponse<Diet>> GetByDate(DateTime date)
        {
            SingleResponse<Diet> response = new SingleResponse<Diet>();

            using (DietDB db = new DietDB())
            {
                Diet diet = await db.Diets.FirstOrDefaultAsync(w => w.Date == date);
                if (diet != null)
                {
                    response.Data = diet;
                    return ResponseFactory.SingleResponseSuccessModel<Diet>(diet);
                }
                return ResponseFactory.SingleResponseNotFoundException<Diet>();
            }
        }

        public async Task<SingleResponse<Diet>> GetById(int id)
        {
            SingleResponse<Diet> response = new SingleResponse<Diet>();

            using (DietDB db = new DietDB())
            {
                Diet diet = await db.Diets.FirstOrDefaultAsync(w => w.ID == id);
                if (diet != null)
                {
                    response.Data = diet;
                    return ResponseFactory.SingleResponseSuccessModel<Diet>(diet);
                }
                return ResponseFactory.SingleResponseNotFoundException<Diet>();
            }
        }

        public async Task<SingleResponse<Diet>> GetByName(Diet item)
        {
            SingleResponse<Diet> response = new SingleResponse<Diet>();

            string name = item.Name;

            using (DietDB db = new DietDB())
            {
                Diet diet = await db.Diets.FirstOrDefaultAsync(w => w.Name == name);
                if (diet != null)
                {
                    response.Data = diet;
                    return ResponseFactory.SingleResponseSuccessModel<Diet>(diet);
                }
                return ResponseFactory.SingleResponseNotFoundException<Diet>();
            }
        }

        public async Task<Response> Insert(Diet item)
        {
            using (DietDB db = new DietDB())
            {
                if (item != null)
                {
                    db.Diets.Add(item);
                    await db.SaveChangesAsync();
                    ResponseFactory.ResponseSuccessModel();
                }
                return ResponseFactory.SingleResponseNotFoundException<Diet>();
            }
        }

        public async Task<Response> Update(Diet item)
        {
            using (DietDB db = new DietDB())
            {
                if (item != null)
                {
                    db.Entry(item).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                    return ResponseFactory.ResponseSuccessModel();
                }
                return ResponseFactory.ResponseNotFoundException();
            }
        }
    }
}

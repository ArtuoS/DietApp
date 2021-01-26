using Common;
using Entities;
using Entities.Factory;
using Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class RestrictionDAL : IRestrictionService
    {
        public async Task<Response> Delete(int id)
        {
            Restriction restriction = new Restriction();
            restriction.ID = id;

            using (DietDB db = new DietDB())
            {
                db.Entry(restriction).State = EntityState.Deleted;
                await db.SaveChangesAsync();
            }

            return ResponseFactory.ResponseSuccessModel();
        }

        public async Task<Response> Disable(int id)
        {
            using (DietDB db = new DietDB())
            {
                Restriction restriction = await db.Restrictions.FirstOrDefaultAsync(u => u.ID == id);
                if (restriction != null)
                {
                    await db.SaveChangesAsync();
                    return ResponseFactory.ResponseSuccessModel();
                }
                return ResponseFactory.ResponseNotFoundException();
            }
        }

        public async Task<QueryResponse<Restriction>> GetAll()
        {
            QueryResponse<Restriction> response = new QueryResponse<Restriction>();

            using (DietDB db = new DietDB())
            {
                List<Restriction> restrictions = await db.Restrictions.ToListAsync();
                if (restrictions != null)
                {
                    response.Data = restrictions;
                    return ResponseFactory.QueryResponseSuccessModel(restrictions);
                }
                return ResponseFactory.QueryResponseNotFoundException<Restriction>();
            }
        }

        public async Task<SingleResponse<Restriction>> GetById(int id)
        {
            SingleResponse<Restriction> response = new SingleResponse<Restriction>();

            using (DietDB db = new DietDB())
            {
                Restriction restriction = await db.Restrictions.FirstOrDefaultAsync(w => w.ID == id);
                if (restriction != null)
                {
                    response.Data = restriction;
                    return ResponseFactory.SingleResponseSuccessModel<Restriction>(restriction);
                }
                return ResponseFactory.SingleResponseNotFoundException<Restriction>();
            }
        }

        public async Task<SingleResponse<Restriction>> GetByName(Restriction item)
        {
            SingleResponse<Restriction> response = new SingleResponse<Restriction>();

            string name = item.Name;

            using (DietDB db = new DietDB())
            {
                Restriction restriction = await db.Restrictions.FirstOrDefaultAsync(w => w.Name == name);
                if (restriction != null)
                {
                    response.Data = restriction;
                    return ResponseFactory.SingleResponseSuccessModel<Restriction>(restriction);
                }
                return ResponseFactory.SingleResponseNotFoundException<Restriction>();
            }
        }

        public async Task<Response> Insert(Restriction item)
        {
            using (DietDB db = new DietDB())
            {
                if (item != null)
                {
                    db.Restrictions.Add(item);
                    await db.SaveChangesAsync();
                    ResponseFactory.ResponseSuccessModel();
                }
                return ResponseFactory.SingleResponseNotFoundException<User>();
            }
        }

        public async Task<Response> Update(Restriction item)
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

using Entities;
using Entities.Factory;
using Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DataAcessLayer
{
    public class UserDAL : IUserService
    {
        public async Task<Response> Delete(int id)
        {
            User user = new User();
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
                User user = await db.Users.FirstOrDefaultAsync(u => u.ID == id);
                if (user != null)
                {
                    user.SetStatus(false);
                    await db.SaveChangesAsync();
                    return ResponseFactory.ResponseSuccessModel();
                }
                return ResponseFactory.ResponseNotFoundException();
            }
        }

        public async Task<QueryResponse<User>> GetAll()
        {
            QueryResponse<User> response = new QueryResponse<User>();

            using (DietDB db = new DietDB())
            {
                List<User> users = await db.Users.Where(a => a.Status).ToListAsync();
                if (users != null)
                {
                    response.Data = users;
                    return ResponseFactory.QueryResponseSuccessModel(users);
                }
                return ResponseFactory.QueryResponseNotFoundException<User>();
            }
        }

        public async Task<SingleResponse<User>> GetById(int id)
        {
            SingleResponse<User> response = new SingleResponse<User>();

            using (DietDB db = new DietDB())
            {
                User user = await db.Users.FirstOrDefaultAsync(w => w.ID == id);
                if (user != null)
                {
                    response.Data = user;
                    return ResponseFactory.SingleResponseSuccessModel<User>(user);
                }
                return ResponseFactory.SingleResponseNotFoundException<User>();
            }
        }

        public async Task<Response> Insert(User item)
        {
            using (DietDB db = new DietDB())
            {
                if (item != null)
                {
                    db.Users.Add(item);
                    await db.SaveChangesAsync();
                    ResponseFactory.ResponseSuccessModel();
                }
                return ResponseFactory.SingleResponseNotFoundException<User>();
            }
        }

        public async Task<Response> Update(User item)
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

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
        public async Task<SingleResponse<User>> Authenticate(string email, string senha)
        {
            using (DietDB db = new DietDB())
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == senha);
                if (user == null)
                {
                    return ResponseFactory.SingleResponseNotFoundException<User>();
                }
                return ResponseFactory.SingleResponseSuccessModel<User>(user);
            }
        }

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

        public async Task<QueryResponse<Food>> GetFoodsFromRestrictionByUserID(int id)
        {
            QueryResponse<Food> response = new QueryResponse<Food>();

            using (DietDB db = new DietDB())
            {
                List<Restriction> restrictions = await db.Restrictions.Include(w => w.Foods).Where(w => w.UserID == id).ToListAsync();

                foreach (Restriction restriction in restrictions)
                {
                    foreach (Food food in restriction.Foods)
                    {
                        response.Data.Add(food);
                    }
                }
            }

            return response;
        }

        public async Task<Response> Insert(User item)
        {
            using (DietDB db = new DietDB())
            {
                if (item != null)
                {
                    //Informa o EF para não tentar cadastrar as comidas dentro da restrição
                    db.Foods.AttachRange(item.Restriction.Foods);
                    //Cadastra a restrição
                    db.Restrictions.Add(item.Restriction);
                    //cadastra o usuario
                    item.RestrictionID = item.Restriction.ID;
                    db.Users.Add(item);
                    await db.SaveChangesAsync();
                    return ResponseFactory.ResponseSuccessModel();
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

using Common;
using Common.Factory;
using Common.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class UserDAL : IUserService
    {
        public Task<Response> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<QueryResponse<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SingleResponse<User>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Response> Insert(User item)
        {
            using (DietDB db = new DietDB())
            {
                db.Users.Add(item);
                await db.SaveChangesAsync();
                return ResponseFactory.ResponseSuccessModel();
            }
        }

        public Task<Response> Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}

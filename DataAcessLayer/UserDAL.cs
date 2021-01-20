using Common;
using Common.Factory;
using Common.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer
{
    public class UserDAL : IUserService
    {
        public Response Delete(int id)
        {
            throw new NotImplementedException();
        }

        public QueryResponse<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public SingleResponse<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Response Insert(User item)
        {
            using (DietDB db = new DietDB())
            {
                db.Users.Add(item);
                db.SaveChangesAsync();
                return ResponseFactory.ResponseSuccessModel();
            }
        }

        public Response Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}

using Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IUserService : IEntityCRUD<User>
    {
        Task<SingleResponse<User>> Authenticate(string email, string senha);
        Task<QueryResponse<Food>> GetFoodsFromRestrictionByUserID(int id);
    }
}

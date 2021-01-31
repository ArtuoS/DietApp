using Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IFoodService : IEntityCRUD<Food>
    {
        Task<SingleResponse<Food>> GetByName(Food name);
        Task<QueryResponse<Food>> GetByCategoryId(int id);
    }
}

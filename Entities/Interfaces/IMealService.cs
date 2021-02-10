using Common;
using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IMealService : IEntityCRUD<Meal>
    {
        Task<SingleResponse<Meal>> GetByName(Meal item);
        Task<QueryResponse<Meal>> GetByCategory(Meal_Category category);
    }
}

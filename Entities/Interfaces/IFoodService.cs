using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces
{
    public interface IFoodService : IEntityCRUD<Food>
    {
        SingleResponse<Food> GetByName(Food item);
    }
}

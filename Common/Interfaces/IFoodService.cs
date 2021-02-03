using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public interface IFoodService : IEntityCRUD<Food>
    {
        SingleResponse<Food> GetByName(Food item);
    }
}

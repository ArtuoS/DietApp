using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public interface IMealService : IEntityCRUD<Meal>
    {
        SingleResponse<Meal> GetByName(Meal item);
    }
}

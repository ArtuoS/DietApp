using Common;
using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IMealService 
    {
        Task<SingleResponse<int>> Insert(Meal item);
        Task<Response> Update(Meal item);
        Task<Response> Delete(int id);
        Task<Response> Disable(int id);
        Task<QueryResponse<Meal>> GetAll();
        Task<SingleResponse<Meal>> GetById(int id);
        Task<SingleResponse<Meal>> GetByName(Meal item);
        Task<QueryResponse<Meal>> GetByCategory(Meal_Category category);
    }
}

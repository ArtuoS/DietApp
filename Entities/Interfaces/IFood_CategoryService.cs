using Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
   public interface IFood_CategoryService : IEntityCRUD<FoodCategory>
    {
        Task<SingleResponse<FoodCategory>> GetByName(string nome);
    }
}

using Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
   public interface IFood_CategoryService : IEntityCRUD<Food_Category>
    {
        Task<SingleResponse<Food_Category>> GetByName(string nome);
    }
}

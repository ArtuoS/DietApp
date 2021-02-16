using Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IDietService : IEntityCRUD<Diet>
    {
        Task<SingleResponse<Diet>> GetByName(Diet item);
        Task<SingleResponse<Diet>> GetByDate(DateTime date);
        Task<SingleResponse<Diet>> GenareteDiet(int id);
    }
}

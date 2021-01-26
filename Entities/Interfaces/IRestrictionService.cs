using Common;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IRestrictionService : IEntityCRUD<Restriction>
    {
        Task<SingleResponse<Restriction>> GetByName(Restriction item);
    }
}

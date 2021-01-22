using Common;
using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces
{
    interface IRestrictionService : IEntityCRUD<Restriction>
    {
        SingleResponse<Restriction> GetByName(Restriction item);
    }
}

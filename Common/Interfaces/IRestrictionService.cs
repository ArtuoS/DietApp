using Common;
using Common.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    interface IRestrictionService : IEntityCRUD<Restriction>
    {
        SingleResponse<Restriction> GetByName(Restriction item);
    }
}

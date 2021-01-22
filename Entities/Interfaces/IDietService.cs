using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Interfaces
{
    interface IDietService : IEntityCRUD<Diet>
    {
        SingleResponse<Diet> GetByName(Diet item);
    }
}

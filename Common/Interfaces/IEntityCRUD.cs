using Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IEntityCRUD<T>
    {
        Task<Response> Insert(T item);
        Task<Response> Update(T item);
        Task<Response> Delete(int id);
        Task<QueryResponse<T>> GetAll();
        Task<SingleResponse<T>> GetById(int id);
    }
}

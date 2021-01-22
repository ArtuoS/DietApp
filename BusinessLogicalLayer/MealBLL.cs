using Common;
using Entities;
using Entities.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    class MealBLL : AbstractValidator<Meal>, IMealService
    {
        public Task<Response> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Disable(int id)
        {
            throw new NotImplementedException();
        }

        public Task<QueryResponse<Meal>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SingleResponse<Meal>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Meal> GetByName(Meal item)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Insert(Meal item)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Update(Meal item)
        {
            throw new NotImplementedException();
        }
    }
}

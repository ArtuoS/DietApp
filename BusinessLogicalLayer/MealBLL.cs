using Common;
using DataAcessLayer;
using Entities;
using Entities.Factory;
using Entities.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
   public class MealBLL : AbstractValidator<Meal>, IMealService
    {
        public MealBLL()
        {
            RuleFor(a => a.Name).NotNull().Length(3, 50).WithMessage("O nome deve ter entre 3 e 50 caractéres.");
        }

        MealDAL mealDAL = new MealDAL();

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
    }
}

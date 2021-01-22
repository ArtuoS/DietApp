using Entities;
using Entities.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace BusinessLogicalLayer
{
    class FoodBLL : AbstractValidator<Food>, IFoodService
    {
        public FoodBLL()
        {
            RuleFor(a => a.Food_Name).NotNull().Length(3, 40).WithMessage("O nome deve conter entre 3 e 40 caracteres");
            //  RuleFor(a => a.).NotNull().Length(3, 40).WithMessage("O nome deve conter entre 3 e 40 caracteres");

        }

        public Task<Response> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Disable(int id)
        {
            throw new NotImplementedException();
        }

        public Task<QueryResponse<Food>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SingleResponse<Food>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Food> GetByName(Food item)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Insert(Food item)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Update(Food item)
        {
            throw new NotImplementedException();
        }
    }
}

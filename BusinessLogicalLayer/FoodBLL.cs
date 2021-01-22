using Entities;
using Entities.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Common;
using DataAcessLayer;
using Entities.Factory;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogicalLayer
{
   public class FoodBLL : AbstractValidator<Food>, IFoodService
    {
        public FoodBLL()
        {
            RuleFor(a => a.Food_Name).NotNull().Length(3, 40).WithMessage("O nome deve conter entre 3 e 40 caracteres");
        }

        FoodDAL foodDAL = new FoodDAL();

        public async Task<Response> Delete(int id)
        {
            return await foodDAL.Delete(id);
        }

        public async Task<Response> Disable(int id)
        {
            return await foodDAL.Disable(id);
        }

        public async Task<QueryResponse<Food>> GetAll()
        {
            try
            {
               return await foodDAL.GetAll();
            }
            catch(Exception ex)
            {
                return ResponseFactory.QueryExceptionModel<Food>(ex);
            }
        }

        public async Task<SingleResponse<Food>> GetById(int id)
        {
            return await foodDAL.GetById(id);
        }

        public async Task<SingleResponse<Food>> GetByName(Food item)
        {
            return await foodDAL.GetByName(item);
        }

        public Task<Response> Update(Food item)
        {
            throw new NotImplementedException();
        }

        public Task<Response> Insert(Food item)
        {
            throw new NotImplementedException();
        }

        SingleResponse<Food> IFoodService.GetByName(Food item)
        {
            throw new NotImplementedException();
        }
    }
}

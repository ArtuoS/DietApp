using Common;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Factory
{
    public static class ResponseFactory
    {
        public static Response ResponseErrorModel(IList<ValidationFailure> errors)
        {
            Response response = new Response();
            StringBuilder sb = new StringBuilder();
            foreach (var failure in errors)
            {
                sb.AppendLine(failure.ErrorMessage);
            }
            response.Success = false;
            response.Message = sb.ToString();
            return response;
        }

        public static Response ResponseSuccessModel()
        {
            Response response = new Response();
            response.Success = true;
            response.Message = "Sucesso.";
            return response;
        }

        public static Response ResponseExceptionModel(Exception ex)
        {
            Response response = new Response();
            response.Success = false;
            response.Message = ex.ToString();
            return response;
        }
    }
}

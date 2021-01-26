using Common;
using Entities;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Factory
{
    public static class ResponseFactory
    {
        // =========== Response ===============
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

        public static Response ResponseNotFoundException()
        {
            Response response = new Response();
            response.Success = false;
            response.Message = "Registro não encontrado.";
            return response;
        }

        // // =========== QueryResponse ===============

        public static QueryResponse<T> QueryResponseSuccessModel<T>(List<T> item)
        {
            QueryResponse<T> response = new QueryResponse<T>();
            response.Success = true;
            response.Data = item;
            response.Message = "Sucesso.";
            return response;
        }

        public static QueryResponse<T> QueryExceptionModel<T>(Exception ex)
        {
            QueryResponse<T> response = new QueryResponse<T>();
            response.Success = false;
            response.Message = ex.ToString();
            return response;
        }

        public static QueryResponse<T> QueryResponseExceptionModel<T>(Exception ex)
        {
            QueryResponse<T> response = new QueryResponse<T>();
            response.Success = false;
            response.Message = ex.ToString();
            return response;
        }

        public static QueryResponse<T> QueryResponseNotFoundException<T>()
        {
            QueryResponse<T> response = new QueryResponse<T>();
            response.Success = false;
            response.Message = "Registro não encontrado.";
            return response;
        }

        // =========== SingleResponse ===============

        public static SingleResponse<T> SingleResponseSuccessModel<T>(T item)
        {
            SingleResponse<T> response = new SingleResponse<T>();
            response.Success = true;
            response.Data = item;
            response.Message = "Sucesso.";
            return response;
        }

        public static SingleResponse<T> SingleExceptionModel<T>(Exception ex)
        {
            SingleResponse<T> response = new SingleResponse<T>();
            response.Success = false;
            response.Message = ex.ToString();
            return response;
        }

        public static SingleResponse<T> SingleResponseExceptionModel<T>(Exception ex)
        {
            SingleResponse<T> response = new SingleResponse<T>();
            response.Success = false;
            response.Message = ex.ToString();
            return response;
        }

        public static SingleResponse<T> SingleResponseNotFoundException<T>()
        {
            SingleResponse<T> response = new SingleResponse<T>();
            response.Success = false;
            response.Message = "Registro não encontrado.";
            return response;
        }
    }
}

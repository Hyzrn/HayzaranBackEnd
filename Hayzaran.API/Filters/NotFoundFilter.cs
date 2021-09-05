using Hayzaran.API.Dtos;
using Hayzaran.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hayzaran.API.Filters
{
    public class NotFoundFilter<TEntity>: IAsyncActionFilter where TEntity : class
    {
        private readonly IService<TEntity> service;

        public NotFoundFilter(IService<TEntity> service)
        {
            this.service = service;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var id = (int)context.ActionArguments.Values.FirstOrDefault();
            var entry = await service.GetByIdAsync(id);

            if (entry != null)
            {
                await next();
            }
            else
            {
                ErrorDto errorDto = new ErrorDto();
                errorDto.Status = 404;
                errorDto.Errors.Add($"Id'si {id} olan ürün veritabanında bulunamadı");
                context.Result = new NotFoundObjectResult(errorDto);
            }
        }
    }
}


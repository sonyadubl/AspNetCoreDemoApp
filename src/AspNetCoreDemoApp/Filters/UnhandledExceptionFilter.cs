using AspNetCoreDemoApp.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDemoApp.Filters
{

    public class UnhandledExceptionFilter : ActionFilterAttribute, IExceptionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!AuthenticationManager.IsAuthenticated(context.HttpContext.Request))
            {
                context.Result = new BadRequestObjectResult(AuthenticationManager.UnauthorizedError());
            }
        }

        public void OnException(ExceptionContext context)
        {
            context.Result = new BadRequestObjectResult(ErrorHandler.GenerateError(999, ErrorHandler.MessageFromException(context.Exception)));
        }
    }
}

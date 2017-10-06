using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using System.Web.Routing;

namespace Alcancia.App_Start
{
    public class ExceptionErrorHandlerAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            var httpContext = HttpContext.Current;
            var requestContext = ((MvcHandler)httpContext.CurrentHandler).RequestContext;

           
                filterContext.Result = new ViewResult
                {
                    ViewName = "~/Views/Shared/Error.cshtml"
                };
            
        }
    }
}
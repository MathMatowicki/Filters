using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filters.Utils
{
    public class CustomPageFilter : IAsyncPageFilter
    {
        public CustomPageFilter(IConfiguration _config)
        {
            int a = 0;
        }
        public void OnPageHandlerSelected(PageHandlerSelectedContext pageContext)
        {
            int a = 0;
        }
        public void OnPageHandlerExecuting(PageHandlerExecutingContext pageContext)
        {
            int a = 0;
        }
        public void OnPageHandlerExecuted(PageHandlerExecutedContext pageContext)
        {
            int a = 0;
        }

        public Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            throw new NotImplementedException();
        }

        public Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
        {
            throw new NotImplementedException();
        }
    }

}

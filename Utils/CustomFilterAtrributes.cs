using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Filters.Utils
{
    public class CustomFilterAttributes : ResultFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var result = context.Result;
            if (result is PageResult)
            {
                var page = ((PageResult)result);
                var af = context.HttpContext.Connection.RemoteIpAddress.AddressFamily.ToString();
                string ad = context.HttpContext.Connection.RemoteIpAddress.ToString();
                page.ViewData["filterMessage"] = "Komunikat z CustomFilterAttributes!!! " + $"{af}" + $"{ad}";
            }
        }

    }
}

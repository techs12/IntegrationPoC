using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace IntegrationPoC.ErrorHandling
{
    public class _ErrorHandling
    {
        private readonly RequestDelegate next;

        public _ErrorHandling(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context )
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            // Throw 500 if unexpected error 
            var code = HttpStatusCode.InternalServerError; 

            if (exception is _NotFoundException)
            {
                code = HttpStatusCode.NotFound;
            }
            else if (exception is _UnauthorizedException)
            {
                code = HttpStatusCode.Unauthorized;
            }
            else if (exception is _Exception)
            {
                code = HttpStatusCode.BadRequest;
            }

            var result = JsonConvert.SerializeObject(new { error = exception.Message });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            return context.Response.WriteAsync(result);
        }
    }

}


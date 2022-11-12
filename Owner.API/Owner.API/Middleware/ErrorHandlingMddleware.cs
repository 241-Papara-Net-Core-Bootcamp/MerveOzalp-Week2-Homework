using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace Owner.API.Middleware
{
    public class ErrorHandlingMddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                // we run next middleware with "next".
                await _next(httpContext);
            }
            catch (System.Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
                
            }
        }

        private static Task HandleExceptionAsync (HttpContext httpContext,Exception exception)
        {
            var code = HttpStatusCode.InternalServerError; //500 if unexception
            var result = JsonSerializer.Serialize(new { error = "An error occured while processig your request. " }); // Error messegae.
            httpContext.Response.ContentType = "application/json"; 
            httpContext.Response.StatusCode = (int)code;
            return httpContext.Response.WriteAsync(result);

        }
    }
}

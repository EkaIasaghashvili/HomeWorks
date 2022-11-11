using HomeWork13.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace HomeWork13.Middleware
{
    public class BookingMiddleware
    {
        private readonly RequestDelegate _next;

        public BookingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext, IConfiguration config)
        {
            var status = Convert.ToBoolean(config.GetSection("BookingNotAllowed").Value);
            if(!status)
                return _next(httpContext);
            else
                return httpContext.Response.WriteAsync("Booking Not Allowed");
        }
    }
}

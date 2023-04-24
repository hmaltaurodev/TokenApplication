using System.Net;

namespace TokenApplication.Auth
{
    public class TokenValidationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;

        public TokenValidationMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _configuration = configuration;
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            string token = _configuration.GetValue<string>("ApiToken");

            if (context.Request.Headers["Token"] == token)
            {
                await _next.Invoke(context);
            }
            else
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                await context.Response.WriteAsync("Invalid Token");
            }
        }
    }
}

using TokenApplication.Auth;

namespace TokenApplication.Extensions
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder UseTokenAuth(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TokenValidationMiddleware>();
        }
    }
}

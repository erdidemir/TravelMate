namespace TravelMate.Api.Middlewares
{
    public static class LanguageCodeMiddlewareExtension
    {
        public static IApplicationBuilder UseLanguageCode(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LanguageCodeMiddleware>();
        }
    }
}

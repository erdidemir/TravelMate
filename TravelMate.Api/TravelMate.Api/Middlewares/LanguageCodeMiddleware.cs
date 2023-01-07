using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;

namespace TravelMate.Api.Middlewares
{
    public class LanguageCodeMiddleware
    {
        readonly RequestDelegate _next;

        public LanguageCodeMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            var headerCodesInfo = httpContext.Request.GetTypedHeaders().AcceptLanguage;
            if (headerCodesInfo is null)
                LanguageInfo.Code = "en-US";

            else if (headerCodesInfo.Count == 0)
                LanguageInfo.Code = "en-US";
            else
                LanguageInfo.Code = headerCodesInfo.FirstOrDefault().Value.ToString();

            await _next.Invoke(httpContext);
        }
    }
}

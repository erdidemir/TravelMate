using Newtonsoft.Json;
using System.Net;
using System.Xml;
using TravelMate.Application.Models.Commons;
using TravelMate.Domain.Enums.Commons;
using static TravelMate.Api.Middlewares.LowercaseJsonSerializer;

namespace TravelMate.Api.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        public RequestDelegate requestDelegate;
        public ExceptionHandlingMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await requestDelegate(context);
            }
            catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }
        private static Task HandleException(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";

            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;

            var settings = new JsonSerializerSettings();
            settings.ContractResolver = new LowercaseContractResolver();

            var responseMessage = JsonConvert.SerializeObject(ResponseViewModelBase<NoContent>.Fail(ex.Message.Replace("Validation failed: \r\n -- ", "").Replace("Severity: Error", ""), ResultTypeEnum.Error), Newtonsoft.Json.Formatting.Indented, settings);
            return context.Response.WriteAsync(responseMessage);
        }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Xml;

namespace TravelMate.Api.Middlewares
{
    public class LowercaseJsonSerializer
    {
        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            ContractResolver = new LowercaseContractResolver()
        };

        public static string SerializeObject(object o)
        {
            return JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented, Settings);
        }

        public class LowercaseContractResolver : DefaultContractResolver
        {
            protected override string ResolvePropertyName(string propertyName)
            {
                return propertyName.ToLower();
            }
        }
    }
}

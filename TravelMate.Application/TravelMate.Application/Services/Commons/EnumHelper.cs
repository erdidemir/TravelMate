using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TravelMate.Application.Services.Commons
{
    public static class EnumHelper<T>
    where T : Enum // This constraint requires C# 7.3 or later.
    {
        public static IList<T> GetValues(Enum value)
        {
            var enumValues = new List<T>();

            foreach (FieldInfo fi in value.GetType().GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                enumValues.Add((T)Enum.Parse(value.GetType(), fi.Name, false));
            }
            return enumValues;
        }

        public static T Parse(string value)
        {
            var a = (T)Enum.Parse(typeof(T), value, true);
            return a;
        }

        public static IList<string> GetNames(Enum value)
        {
            return value.GetType().GetFields(BindingFlags.Static | BindingFlags.Public).Select(fi => fi.Name).ToList();
        }

        public static List<EnumModel> GetDisplayValues()
        {
            var enumModelList = new List<EnumModel>();
            var enumList = Enum.GetNames(typeof(T));

            foreach (var item in enumList)
            {
                var enumModel = new EnumModel();
                var enm = Parse(item);
                var displayName = GetDisplayValue(enm);
                enumModel.Id = (int)Enum.Parse(typeof(T), enm.ToString());
                enumModel.Name = displayName;
                enumModelList.Add(enumModel);
            }

            return enumModelList;
        }

        private static string lookupResource(Type resourceManagerProvider, string resourceKey)
        {
            var resourceKeyProperty = resourceManagerProvider.GetProperty(resourceKey,
                BindingFlags.Static | BindingFlags.Public, null, typeof(string),
                new Type[0], null);
            if (resourceKeyProperty != null)
            {
                return (string)resourceKeyProperty.GetMethod.Invoke(null, null);
            }

            return resourceKey; // Fallback with the key name
        }

        public static string GetDisplayValue(T value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            var descriptionAttributes = fieldInfo.GetCustomAttributes(
                typeof(DisplayAttribute), false) as DisplayAttribute[];

            //if (descriptionAttributes[0].ResourceType != null)
            //    return lookupResource(descriptionAttributes[0].ResourceType, descriptionAttributes[0].Name);

            if (descriptionAttributes == null) return string.Empty;
            return (descriptionAttributes.Length > 0) ? descriptionAttributes[0].Name : value.ToString();
        }

    }
    public class EnumModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

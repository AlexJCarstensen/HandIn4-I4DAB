using System.Web.Script.Serialization;

namespace Handin4GDEMDS.ModelAccessor
{
    public static class JsonStringToObject<T>
    {
        public static T Convert(string jsonString)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Deserialize<T>(jsonString);
        }
    }
}
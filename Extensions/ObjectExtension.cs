using Newtonsoft.Json;

namespace freaxnx01.Extensions
{
    public static class ObjectExtension
    {
        public static string SerializeToJson(this object theObject)
        {
            switch (theObject.GetType().ToString())
            {
                case "System.Data.DataSet":
                case "System.Data.DataTable":
                    return JsonConvert.SerializeObject(theObject, Newtonsoft.Json.Formatting.Indented);
                default:
                    return System.Text.Json.JsonSerializer.Serialize(theObject);
            }
        }
    }
}
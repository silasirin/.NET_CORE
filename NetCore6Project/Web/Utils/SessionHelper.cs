using Newtonsoft.Json;

namespace Web.Utils
{
    public static class SessionHelper
    {
        //Set
        public static void SetProductJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        //Get
        public static T GetProductSession<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }

    }
}

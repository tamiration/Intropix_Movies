using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intropix_Movies.Helpers
{
    public static class SessionExtender
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            var sts = JsonConvert.SerializeObject(value);
            session.SetString("michal", "myself");
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}

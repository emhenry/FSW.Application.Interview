using Newtonsoft.Json;
using System.Collections.Generic;

namespace FSW.Application.Interview.Model
{
    public class JsonConverter
    {
        public T Deserialize<T>(string json)
        {
            return (T)JsonConvert.DeserializeObject<T>(json);        
        }        
    }
}

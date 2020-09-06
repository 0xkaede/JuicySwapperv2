using Newtonsoft.Json;

namespace Juicy_Swapper_v2.Classes.API
{
    class StatusAPI
    {
        public class Status
        {
            [JsonProperty("isOnline")]
            public bool IsOnline { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }
        }
    }
}

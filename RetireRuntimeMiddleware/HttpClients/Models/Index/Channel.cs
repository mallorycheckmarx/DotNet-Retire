using System;
using Newtonsoft.Json;

namespace RetireRuntimeMiddleware.HttpClients.Models.Index
{
    internal class Channel
    {
        [JsonProperty("releases.json")]
        public Uri ReleasesUrl { get; set; }
    }
}
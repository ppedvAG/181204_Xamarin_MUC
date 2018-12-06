using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MalleView
{
    public class WebcamItem
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        public string Location => $"{Latitude} / {Longitude}";
    }
}

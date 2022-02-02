using System;
using Newtonsoft.Json;

namespace EventModel
{
    public class CountryData
    {
        [JsonProperty(PropertyName = "Trip ID")]
        public string Trip_ID { get; set; }
        public string Duration { get; set; }

        [JsonProperty(PropertyName = "Start Date")]
        public string Start_Date { get; set; }

        [JsonProperty(PropertyName = "End Date")]
        public string End_Date { get; set; }

        [JsonProperty(PropertyName = "Bike #")]
        public string Bike { get; set; }
        [JsonProperty(PropertyName = "Subscriber Type")]
        public string Subscriber_Type { get; set; }

        [JsonProperty(PropertyName = "Zip Code")]
        public string Zip_Code { get; set; }
        public DateTime ProcessDate { get; set; }
    }
}

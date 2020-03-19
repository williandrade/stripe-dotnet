namespace Stripe.Sigma
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ScheduledQueryRun : StripeEntity<ScheduledQueryRun>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("data_load_time")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime DataLoadTime { get; set; }

        [JsonProperty("error")]
        public ScheduledQueryRunError Error { get; set; }

        [JsonProperty("file")]
        public File File { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("result_available_until")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime ResultAvailableUntil { get; set; }

        [JsonProperty("sql")]
        public string Sql { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}

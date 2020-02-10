namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class FileLinkCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

<<<<<<< HEAD
=======
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

>>>>>>> Remove all docs from entities, options and services (#1913)
        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}

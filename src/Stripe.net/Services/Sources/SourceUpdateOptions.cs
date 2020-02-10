namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceUpdateOptions : BaseOptions, IHasMetadata
    {
<<<<<<< HEAD
        [JsonProperty("amount")]
        public long? Amount { get; set; }

=======
>>>>>>> Remove all docs from entities, options and services (#1913)
        [JsonProperty("mandate")]
        public SourceMandateOptions Mandate { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("owner")]
        public SourceOwnerOptions Owner { get; set; }

        [JsonProperty("source_order")]
        public SourceSourceOrderOptions SourceOrder { get; set; }

        [JsonProperty("card")]
        public SourceCardUpdateOptions Card { get; set; }
    }
}

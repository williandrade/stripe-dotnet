namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ThreeDSecureCreateOptions : BaseOptions
    {
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}

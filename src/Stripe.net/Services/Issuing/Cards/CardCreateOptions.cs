namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("authorization_controls")]
        public AuthorizationControlsOptions AuthorizationControls { get; set; }

        [JsonProperty("cardholder")]
        public string Cardholder { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("replacement_for")]
        public string ReplacementFor { get; set; }

        [JsonProperty("replacement_reason")]
        public string ReplacementReason { get; set; }

        [JsonProperty("shipping")]
        public CardShippingOptions Shipping { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

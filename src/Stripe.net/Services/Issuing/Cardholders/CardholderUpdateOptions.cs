namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardholderUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("authorization_controls")]
        public CardholderAuthorizationControlsOptions AuthorizationControls { get; set; }

        [JsonProperty("billing")]
        public BillingOptions Billing { get; set; }

        [JsonProperty("company")]
        public CardholderCompanyOptions Company { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("individual")]
        public CardholderIndividualOptions Individual { get; set; }

        [JsonProperty("is_default")]
        public bool? IsDefault { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

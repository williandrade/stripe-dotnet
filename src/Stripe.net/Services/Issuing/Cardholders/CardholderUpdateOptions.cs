namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class CardholderUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The cardholder’s billing address.
        /// </summary>
        [JsonProperty("billing")]
        public BillingOptions Billing { get; set; }

        /// <summary>
        /// Additional information about a company cardholder.
        /// </summary>
        [JsonProperty("company")]
        public CardholderCompanyOptions Company { get; set; }

        /// <summary>
        /// The cardholder’s email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Additional information about an individual cardholder.
        /// </summary>
        [JsonProperty("individual")]
        public CardholderIndividualOptions Individual { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a charge object. It can be useful for
        /// storing additional information about the customer in a structured format. It's often a
        /// good idea to store an email address in metadata for tracking later.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The cardholder’s phone number. This will be transformed to E.164 if it is not provided
        /// in that format already.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Spending controls that give you control over how your cardholders can make charges.
        /// </summary>
        [JsonProperty("spending_controls")]
        public CardholderSpendingControlsOptions SpendingControls { get; set; }

        /// <summary>
        /// Specifies whether to permit authorizations on this cardholder’s cards. Possible values
        /// are <c>active</c> or <c>inactive</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

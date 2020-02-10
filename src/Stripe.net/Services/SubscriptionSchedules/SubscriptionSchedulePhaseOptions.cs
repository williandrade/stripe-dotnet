namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionSchedulePhaseOptions : INestedOptions
    {
        [JsonProperty("application_fee_percent")]
        public decimal? ApplicationFeePercent { get; set; }

        [JsonProperty("billing_thresholds")]
        public SubscriptionBillingThresholdsOptions BillingThresholds { get; set; }

        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        [JsonProperty("default_tax_rates")]
        public List<string> DefaultTaxRates { get; set; }

        [JsonProperty("end_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? EndDate { get; set; }

        [JsonProperty("invoice_settings")]
        public SubscriptionScheduleInvoiceSettingsOptions InvoiceSettings { get; set; }

        [JsonProperty("iterations")]
        public long? Iterations { get; set; }

        [JsonProperty("plans")]
        public List<SubscriptionSchedulePhaseItemOptions> Plans { get; set; }

<<<<<<< HEAD
        [JsonProperty("proration_behavior")]
        public string ProrationBehavior { get; set; }

=======
>>>>>>> Remove all docs from entities, options and services (#1913)
        [JsonProperty("start_date")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? StartDate { get; set; }

        [Obsolete("Use DefaultTaxRates")]
        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("trial")]
        public bool? Trial { get; set; }

        [JsonProperty("trial_end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? TrialEnd { get; set; }
    }
}

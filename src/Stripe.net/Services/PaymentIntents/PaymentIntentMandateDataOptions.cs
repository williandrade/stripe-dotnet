namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class PaymentIntentMandateDataOptions : INestedOptions
    {
        /// <summary>
        /// This hash contains details about the customer acceptance of the Mandate.
        /// </summary>
        [JsonProperty("customer_acceptance")]
        public PaymentIntentMandateDataCustomerAcceptanceOptions CustomerAcceptance { get; set; }
    }
}

namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargeListOptions : ListOptionsWithCreated
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }

<<<<<<< HEAD
=======
        [Obsolete("This parameter is deprecated. Filter the returned list of charges instead.")]
        [JsonProperty("source")]
        public ChargeSourceListOptions Source { get; set; }

>>>>>>> Remove all docs from entities, options and services (#1913)
        [JsonProperty("transfer_group")]
        public string TransferGroup { get; set; }
    }
}

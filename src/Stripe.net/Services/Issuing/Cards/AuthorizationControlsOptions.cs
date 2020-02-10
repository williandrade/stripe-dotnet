namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    // TODO: Rename to CardAuthorizationControls in a future major version and move to Card folder.
    public class AuthorizationControlsOptions : INestedOptions
    {
        [JsonProperty("allowed_categories")]
        public List<string> AllowedCategories { get; set; }

        [JsonProperty("blocked_categories")]
        public List<string> BlockedCategories { get; set; }

<<<<<<< HEAD
=======
        [Obsolete("Use SpendingLimits instead.")]
        [JsonProperty("max_amount")]
        public long? MaxAmount { get; set; }

>>>>>>> Remove all docs from entities, options and services (#1913)
        [JsonProperty("max_approvals")]
        public long? MaxApprovals { get; set; }

        [JsonProperty("spending_limits")]
        public List<CardAuthorizationControlsSpendingLimitOptions> SpendingLimits { get; set; }
    }
}

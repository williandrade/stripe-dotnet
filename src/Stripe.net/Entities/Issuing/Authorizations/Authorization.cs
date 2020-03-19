namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Authorization : StripeEntity<Authorization>, IHasId, IHasMetadata, IHasObject, IBalanceTransactionSource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("authorization_method")]
        public string AuthorizationMethod { get; set; }

        [JsonProperty("authorized_amount")]
        public long AuthorizedAmount { get; set; }

        [JsonProperty("authorized_currency")]
        public string AuthorizedCurrency { get; set; }

        [JsonProperty("balance_transactions")]
        public List<BalanceTransaction> BalanceTransactions { get; set; }

        [JsonProperty("card")]
        public Card Card { get; set; }

        #region Expandable Cardholder
        [JsonIgnore]
        public string CardholderId
        {
            get => this.InternalCardholder?.Id;
            set => this.InternalCardholder = SetExpandableFieldId(value, this.InternalCardholder);
        }

        [JsonIgnore]
        public Cardholder Cardholder
        {
            get => this.InternalCardholder?.ExpandedObject;
            set => this.InternalCardholder = SetExpandableFieldObject(value, this.InternalCardholder);
        }

        [JsonProperty("cardholder")]
        [JsonConverter(typeof(ExpandableFieldConverter<Cardholder>))]
        internal ExpandableField<Cardholder> InternalCardholder { get; set; }
        #endregion

        [JsonProperty("created")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Created { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("held_amount")]
        public long HeldAmount { get; set; }

        [JsonProperty("held_currency")]
        public string HeldCurrency { get; set; }

        [JsonProperty("is_held_amount_controllable")]
        public bool IsHeldAmountControllable { get; set; }

        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("merchant_amount")]
        public long MerchantAmount { get; set; }

        [JsonProperty("merchant_currency")]
        public string MerchantCurrency { get; set; }

        [JsonProperty("merchant_data")]
        public MerchantData MerchantData { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("pending_authorized_amount")]
        public long PendingAuthorizedAmount { get; set; }

        [JsonProperty("pending_held_amount")]
        public long PendingHeldAmount { get; set; }

        [JsonProperty("pending_request")]
        public AuthorizationPendingRequest PendingRequest { get; set; }

        [JsonProperty("request_history")]
        public List<RequestHistory> RequestHistory { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("transactions")]
        public List<Transaction> Transactions { get; set; }

        [JsonProperty("verification_data")]
        public VerificationData VerificationData { get; set; }

        [JsonProperty("wallet")]
        public string Wallet { get; set; }

        [JsonProperty("wallet_provider")]
        public string WalletProvider { get; set; }
    }
}

namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class BalanceTransactionService : Service<BalanceTransaction>,
        IListable<BalanceTransaction, BalanceTransactionListOptions>,
        IRetrievable<BalanceTransaction, BalanceTransactionGetOptions>
    {
        public BalanceTransactionService()
            : base(null)
        {
        }

        public BalanceTransactionService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/balance_transactions";

        public virtual BalanceTransaction Get(string id, BalanceTransactionGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<BalanceTransaction> GetAsync(string id, BalanceTransactionGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<BalanceTransaction> List(BalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<BalanceTransaction>> ListAsync(BalanceTransactionListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<BalanceTransaction> ListAutoPaging(BalanceTransactionListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}

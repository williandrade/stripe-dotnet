namespace Stripe.Radar
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ValueListItemService : Service<ValueListItem>,
        ICreatable<ValueListItem, ValueListItemCreateOptions>,
        IDeletable<ValueListItem, ValueListItemDeleteOptions>,
        IListable<ValueListItem, ValueListItemListOptions>,
        IRetrievable<ValueListItem, ValueListItemGetOptions>
    {
        public ValueListItemService()
            : base(null)
        {
        }

        public ValueListItemService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/radar/value_list_items";

        public virtual ValueListItem Create(ValueListItemCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<ValueListItem> CreateAsync(ValueListItemCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual ValueListItem Delete(string id, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(id, null, requestOptions);
        }

        public virtual Task<ValueListItem> DeleteAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.DeleteEntityAsync(id, null, requestOptions, cancellationToken);
        }

        public virtual ValueListItem Get(string id, ValueListItemGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

        public virtual Task<ValueListItem> GetAsync(string id, ValueListItemGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ValueListItem> List(ValueListItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<ValueListItem>> ListAsync(ValueListItemListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ValueListItem> ListAutoPaging(ValueListItemListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }
    }
}

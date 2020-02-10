namespace Stripe.Radar
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class ValueListService : Service<ValueList>,
        ICreatable<ValueList, ValueListCreateOptions>,
        IDeletable<ValueList, ValueListDeleteOptions>,
        IListable<ValueList, ValueListListOptions>,
        IRetrievable<ValueList, ValueListGetOptions>
    {
        public ValueListService()
            : base(null)
        {
        }

        public ValueListService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/radar/value_lists";

        public virtual ValueList Create(ValueListCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<ValueList> CreateAsync(ValueListCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual ValueList Delete(string id, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(id, null, requestOptions);
        }

<<<<<<< HEAD
        public virtual Task<ValueList> DeleteAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
=======
        public virtual Task<ValueList> DeleteAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
>>>>>>> Rename all parameters in services' methods to be consistent (#1912)
        {
            return this.DeleteEntityAsync(id, null, requestOptions, cancellationToken);
        }

        public virtual ValueList Get(string id, ValueListGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

<<<<<<< HEAD
        public virtual Task<ValueList> GetAsync(string id, ValueListGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
=======
        public virtual Task<ValueList> GetAsync(string id, ValueListGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
>>>>>>> Rename all parameters in services' methods to be consistent (#1912)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<ValueList> List(ValueListListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<ValueList>> ListAsync(ValueListListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<ValueList> ListAutoPaging(ValueListListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual ValueList Update(string id, ValueListUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

<<<<<<< HEAD
        public virtual Task<ValueList> UpdateAsync(string id, ValueListUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
=======
        public virtual Task<ValueList> UpdateAsync(string id, ValueListUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
>>>>>>> Rename all parameters in services' methods to be consistent (#1912)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}

namespace Stripe.Terminal
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Infrastructure;

    public class LocationService : Service<Location>,
        ICreatable<Location, LocationCreateOptions>,
        IDeletable<Location, LocationDeleteOptions>,
        IListable<Location, LocationListOptions>,
        IRetrievable<Location, LocationGetOptions>,
        IUpdatable<Location, LocationUpdateOptions>
    {
        public LocationService()
            : base(null)
        {
        }

        public LocationService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/terminal/locations";

        public virtual Location Create(LocationCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(options, requestOptions);
        }

        public virtual Task<Location> CreateAsync(LocationCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public virtual Location Delete(string id, RequestOptions requestOptions = null)
        {
            return this.DeleteEntity(id, null, requestOptions);
        }

<<<<<<< HEAD
        public virtual Task<Location> DeleteAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
=======
        public virtual Task<Location> DeleteAsync(string id, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
>>>>>>> Rename all parameters in services' methods to be consistent (#1912)
        {
            return this.DeleteEntityAsync(id, null, requestOptions, cancellationToken);
        }

        public virtual Location Get(string id, LocationGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.GetEntity(id, options, requestOptions);
        }

<<<<<<< HEAD
        public virtual Task<Location> GetAsync(string id, LocationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
=======
        public virtual Task<Location> GetAsync(string id, LocationGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
>>>>>>> Rename all parameters in services' methods to be consistent (#1912)
        {
            return this.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Location> List(LocationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntities(options, requestOptions);
        }

        public virtual Task<StripeList<Location>> ListAsync(LocationListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListEntitiesAsync(options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Location> ListAutoPaging(LocationListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListEntitiesAutoPaging(options, requestOptions);
        }

        public virtual Location Update(string id, LocationUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.UpdateEntity(id, options, requestOptions);
        }

<<<<<<< HEAD
        public virtual Task<Location> UpdateAsync(string id, LocationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
=======
        public virtual Task<Location> UpdateAsync(string id, LocationUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default(CancellationToken))
>>>>>>> Rename all parameters in services' methods to be consistent (#1912)
        {
            return this.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}

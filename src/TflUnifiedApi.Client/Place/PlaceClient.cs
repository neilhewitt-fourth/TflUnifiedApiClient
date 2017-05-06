using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TflUnifiedApiClient
{
    public class PlaceClient : ApiClientBase
    {
        /// <summary>Gets a list of all of the available place property categories and keys.</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiPlaceException">A server side error occurred.</exception>
        public Task<ObservableCollection<PlaceCategory>> MetaCategoriesAsync()
        {
            return MetaCategoriesAsync(CancellationToken.None);
        }

        /// <summary>Gets a list of all of the available place property categories and keys.</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiPlaceException">A server side error occurred.</exception>
        public async Task<ObservableCollection<PlaceCategory>> MetaCategoriesAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<ObservableCollection<PlaceCategory>>(cancellationToken, "/Place/Meta/Categories");
        }

        /// <summary>Gets a list of the available types of Place.</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiPlaceException">A server side error occurred.</exception>
        public Task<ObservableCollection<PlaceCategory>> MetaPlaceTypesAsync()
        {
            return MetaPlaceTypesAsync(CancellationToken.None);
        }

        /// <summary>Gets a list of the available types of Place.</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiPlaceException">A server side error occurred.</exception>
        public async Task<ObservableCollection<PlaceCategory>> MetaPlaceTypesAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<ObservableCollection<PlaceCategory>>(cancellationToken, "/Place/Meta/PlaceTypes");
        }

        /// <summary>Gets the set of streets associated with a post code.</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiPlaceException">A server side error occurred.</exception>
        public Task<StreetResponse> GetStreetsByPostCodeAsync(string postcode, string postcodeInputpostcode)
        {
            return GetStreetsByPostCodeAsync(postcode, postcodeInputpostcode, CancellationToken.None);
        }

        /// <summary>Gets the set of streets associated with a post code.</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiPlaceException">A server side error occurred.</exception>
        public async Task<StreetResponse> GetStreetsByPostCodeAsync(string postcode, string postcodeInputpostcode, CancellationToken cancellationToken)
        {
            if (postcode == null)
                throw new ArgumentNullException("postcode");

            return await GetAsync<StreetResponse>(cancellationToken, "/Place/Address/Streets/{Postcode}", ("postcode", postcode));
        }

        /// <summary>Gets all places of a given type</summary>
        /// <param name="types">A comma-separated list of the types to return. Max. approx 12 types.
        ///             A valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint.</param>
        /// <param name="activeOnly">An optional parameter to limit the results to active records only (Currently only the 'VariableMessageSign' place type is supported)</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiPlaceException">A server side error occurred.</exception>
        public Task<ObservableCollection<Place>> GetByTypeAsync(IEnumerable<string> types, bool? activeOnly)
        {
            return GetByTypeAsync(types, activeOnly, CancellationToken.None);
        }

        /// <summary>Gets all places of a given type</summary>
        /// <param name="types">A comma-separated list of the types to return. Max. approx 12 types.
        ///             A valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint.</param>
        /// <param name="activeOnly">An optional parameter to limit the results to active records only (Currently only the 'VariableMessageSign' place type is supported)</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiPlaceException">A server side error occurred.</exception>
        public async Task<ObservableCollection<Place>> GetByTypeAsync(IEnumerable<string> types, bool? activeOnly, CancellationToken cancellationToken)
        {
            if (types == null)
                throw new ArgumentNullException("types");

            return await GetAsync<ObservableCollection<Place>>(cancellationToken, "/Place/Type/{types}", ("types", types));
        }

        /// <summary>Gets the place with the given id.</summary>
        /// <param name="id">The id of the place, you can use the /Place/Types/{types} endpoint to get a list of places for a given type including their ids</param>
        /// <param name="includeChildren">Defaults to false. If true child places e.g. individual charging stations at a charge point while be included, otherwise just the URLs of any child places will be returned</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiPlaceException">A server side error occurred.</exception>
        public Task<ObservableCollection<Place>> GetAsync(string id, bool? includeChildren)
        {
            return GetAsync(id, includeChildren, CancellationToken.None);
        }

        /// <summary>Gets the place with the given id.</summary>
        /// <param name="id">The id of the place, you can use the /Place/Types/{types} endpoint to get a list of places for a given type including their ids</param>
        /// <param name="includeChildren">Defaults to false. If true child places e.g. individual charging stations at a charge point while be included, otherwise just the URLs of any child places will be returned</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiPlaceException">A server side error occurred.</exception>
        public async Task<ObservableCollection<Place>> GetAsync(string id, bool? includeChildren, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            return await GetAsync<ObservableCollection<Place>>(cancellationToken, "/Place/{id}", ("id", id));
        }

        /// <summary>Gets the places that lie within the bounding box defined by the lat/lon of its north-west and south-east corners. Optionally filters
        ///             on type and can strip properties for a smaller payload.</summary>
        /// <param name="categories">an optional list of comma separated property categories to return in the Place's property bag. If null or empty, all categories of property are returned. Pass the keyword "none" to return no properties (a valid list of categories can be obtained from the /Place/Meta/categories endpoint)</param>
        /// <param name="includeChildren">Defaults to false. If true child places e.g. individual charging stations at a charge point while be included, otherwise just the URLs of any child places will be returned</param>
        /// <param name="type">place types to filter on, or null to return all types</param>
        /// <param name="activeOnly">An optional parameter to limit the results to active records only (Currently only the 'VariableMessageSign' place type is supported)</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiPlaceException">A server side error occurred.</exception>
        public Task<ObservableCollection<StopPoint>> GetByGeoBoxAsync(IEnumerable<string> categories, bool? includeChildren, IEnumerable<string> type, bool? activeOnly, double boundingBoxSWLat, double boundingBoxSWLon, double boundingBoxNELat, double boundingBoxNELon)
        {
            return GetByGeoBoxAsync(categories, includeChildren, type, activeOnly, boundingBoxSWLat, boundingBoxSWLon, boundingBoxNELat, boundingBoxNELon, CancellationToken.None);
        }

        /// <summary>Gets the places that lie within the bounding box defined by the lat/lon of its north-west and south-east corners. Optionally filters
        ///             on type and can strip properties for a smaller payload.</summary>
        /// <param name="categories">an optional list of comma separated property categories to return in the Place's property bag. If null or empty, all categories of property are returned. Pass the keyword "none" to return no properties (a valid list of categories can be obtained from the /Place/Meta/categories endpoint)</param>
        /// <param name="includeChildren">Defaults to false. If true child places e.g. individual charging stations at a charge point while be included, otherwise just the URLs of any child places will be returned</param>
        /// <param name="type">place types to filter on, or null to return all types</param>
        /// <param name="activeOnly">An optional parameter to limit the results to active records only (Currently only the 'VariableMessageSign' place type is supported)</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiPlaceException">A server side error occurred.</exception>
        public async Task<ObservableCollection<StopPoint>> GetByGeoBoxAsync(IEnumerable<string> categories, bool? includeChildren, IEnumerable<string> type, bool? activeOnly, double boundingBoxSWLat, double boundingBoxSWLon, double boundingBoxNELat, double boundingBoxNELon, CancellationToken cancellationToken)
        {
            return await GetAsync<ObservableCollection<StopPoint>>(cancellationToken,
                "/Place",
                ("categories", categories),
                ("includeChildren", includeChildren),
                ("type", type),
                ("activeOnly", activeOnly),
                ("bbBoxpointsswLat", boundingBoxSWLat),
                ("bbBoxpointsswLon", boundingBoxSWLon),
                ("bbBoxpointsneLat", boundingBoxNELat),
                ("bbBoxpointsneLon", boundingBoxNELon)
                );
        }

        /// <summary>Gets any {laces of the given type whose geography intersects the given latitude and longitude. In practice this means the Place
        ///             must be polygonal e.g. a BoroughBoundary.</summary>
        /// <param name="type">The place type (a valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint)</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiPlaceException">A server side error occurred.</exception>
        public Task<object> GetAtAsync(IEnumerable<string> type, string lat, string lon, double locationlat, double locationlon)
        {
            return GetAtAsync(type, lat, lon, locationlat, locationlon, CancellationToken.None);
        }

        /// <summary>Gets any {laces of the given type whose geography intersects the given latitude and longitude. In practice this means the Place
        ///             must be polygonal e.g. a BoroughBoundary.</summary>
        /// <param name="type">The place type (a valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint)</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiPlaceException">A server side error occurred.</exception>
        public async Task<object> GetAtAsync(IEnumerable<string> type, string lat, string lon, double locationlat, double locationlon, CancellationToken cancellationToken)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            if (lat == null)
                throw new ArgumentNullException("lat");

            if (lon == null)
                throw new ArgumentNullException("lon");

            return await GetAsync<object>(cancellationToken, "/Place/{type}/At/{lat}/{lon}", ("type", type), ("lat", lat), ("lon", lon));
        }

        /// <summary>Gets the place overlay for a given set of co-ordinates and a given width/height.</summary>
        /// <param name="z">The zoom level</param>
        /// <param name="type">The place type (a valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint)</param>
        /// <param name="width">The width of the requested overlay.</param>
        /// <param name="height">The height of the requested overlay.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiPlaceException">A server side error occurred.</exception>
        public Task<object> GetOverlayAsync(int z, IEnumerable<string> type, int width, int height, string lat, string lon, double locationlat, double locationlon)
        {
            return GetOverlayAsync(z, type, width, height, lat, lon, locationlat, locationlon, CancellationToken.None);
        }

        /// <summary>Gets the place overlay for a given set of co-ordinates and a given width/height.</summary>
        /// <param name="z">The zoom level</param>
        /// <param name="type">The place type (a valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint)</param>
        /// <param name="width">The width of the requested overlay.</param>
        /// <param name="height">The height of the requested overlay.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiPlaceException">A server side error occurred.</exception>
        public async Task<object> GetOverlayAsync(int z, IEnumerable<string> type, int width, int height, string lat, string lon, double locationlat, double locationlon, CancellationToken cancellationToken)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            if (lat == null)
                throw new ArgumentNullException("lat");

            if (lon == null)
                throw new ArgumentNullException("lon");

            return await GetAsync<object>(cancellationToken, 
                "/Place/{type}/overlay/{z}/{Lat}/{Lon}/{width}/{height}",
                ("type", type),
                ("z", z),
                ("lat", lat),
                ("lon", lon),
                ("width", width),
                ("height", height)
                );
        }
    }
}

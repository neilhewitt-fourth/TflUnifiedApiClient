using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TflUnifiedApiClient
{
    public class CabwiseClient : ApiClientBase
    {
        /// <summary>Gets taxis and minicabs contact information</summary>
        /// <param name="lat">Latitude</param>
        /// <param name="lon">Longitude</param>
        /// <param name="optype">Operator Type e.g Minicab, Executive, Limousine</param>
        /// <param name="wc">Wheelchair accessible</param>
        /// <param name="radius">The radius of the bounding circle in metres</param>
        /// <param name="name">Trading name of operating company</param>
        /// <param name="maxResults">An optional parameter to limit the number of results return. Default and maximum is 20.</param>
        /// <param name="legacyFormat">Legacy Format</param>
        /// <param name="forceXml">Force Xml</param>
        /// <param name="twentyFourSevenOnly">Twenty Four Seven Only</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiCabwiseException">A server side error occurred.</exception>
        public Task<object> GetAsync(double lat, double lon, string optype, string wc, double? radius, string name, int? maxResults, bool? legacyFormat, bool? forceXml, bool? twentyFourSevenOnly)
        {
            return GetAsync(lat, lon, optype, wc, radius, name, maxResults, legacyFormat, forceXml, twentyFourSevenOnly, CancellationToken.None);
        }

        /// <summary>Gets taxis and minicabs contact information</summary>
        /// <param name="lat">Latitude</param>
        /// <param name="lon">Longitude</param>
        /// <param name="optype">Operator Type e.g Minicab, Executive, Limousine</param>
        /// <param name="wc">Wheelchair accessible</param>
        /// <param name="radius">The radius of the bounding circle in metres</param>
        /// <param name="name">Trading name of operating company</param>
        /// <param name="maxResults">An optional parameter to limit the number of results return. Default and maximum is 20.</param>
        /// <param name="legacyFormat">Legacy Format</param>
        /// <param name="forceXml">Force Xml</param>
        /// <param name="twentyFourSevenOnly">Twenty Four Seven Only</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiCabwiseException">A server side error occurred.</exception>
        public async Task<object> GetAsync(double lat, double lon, string optype, string wc, double? radius, string name, int? maxResults, bool? legacyFormat, bool? forceXml, bool? twentyFourSevenOnly, CancellationToken cancellationToken)
        {
            return await GetAsync<object>(cancellationToken, 
                "/Cabwise/search", 
                ("lat", lat),
                ("lon", lon),
                ("optype", optype),
                ("wc", wc),
                ("radius", radius),
                ("name", name),
                ("maxResults", maxResults),
                ("legacyFormat", legacyFormat),
                ("forceXml", forceXml),
                ("twentyFourSevenOnly", twentyFourSevenOnly)
                );
        }
    }
}

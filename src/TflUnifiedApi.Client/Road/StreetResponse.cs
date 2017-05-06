using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class StreetResponse
    {
        public IEnumerable<StreetMatch> Matches { get; set; }
        public string PostCode { get; set; }
    }
}


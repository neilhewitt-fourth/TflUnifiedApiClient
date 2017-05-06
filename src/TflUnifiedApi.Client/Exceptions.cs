using System;
using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class TflUnifiedApiAccidentStatsException : Exception
    {
        public string StatusCode { get; private set; }

        public string Response { get; private set; }

        public Dictionary<string, IEnumerable<string>> Headers { get; private set; }

        public TflUnifiedApiAccidentStatsException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }


    public class TflUnifiedApiAccidentStatsException<TResult> : TflUnifiedApiAccidentStatsException
    {
        public TResult Result { get; private set; }

        public TflUnifiedApiAccidentStatsException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }


    public class TflUnifiedApiAirQualityException : Exception
    {
        public string StatusCode { get; private set; }

        public string Response { get; private set; }

        public Dictionary<string, IEnumerable<string>> Headers { get; private set; }

        public TflUnifiedApiAirQualityException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }


    public class TflUnifiedApiAirQualityException<TResult> : TflUnifiedApiAirQualityException
    {
        public TResult Result { get; private set; }

        public TflUnifiedApiAirQualityException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }


    public class TflUnifiedApiBikePointException : Exception
    {
        public string StatusCode { get; private set; }

        public string Response { get; private set; }

        public Dictionary<string, IEnumerable<string>> Headers { get; private set; }

        public TflUnifiedApiBikePointException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }


    public class TflUnifiedApiBikePointException<TResult> : TflUnifiedApiBikePointException
    {
        public TResult Result { get; private set; }

        public TflUnifiedApiBikePointException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }


    public class TflUnifiedApiCabwiseException : Exception
    {
        public string StatusCode { get; private set; }

        public string Response { get; private set; }

        public Dictionary<string, IEnumerable<string>> Headers { get; private set; }

        public TflUnifiedApiCabwiseException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }


    public class TflUnifiedApiCabwiseException<TResult> : TflUnifiedApiCabwiseException
    {
        public TResult Result { get; private set; }

        public TflUnifiedApiCabwiseException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }


    public class TflUnifiedApiJourneyException : Exception
    {
        public string StatusCode { get; private set; }

        public string Response { get; private set; }

        public Dictionary<string, IEnumerable<string>> Headers { get; private set; }

        public TflUnifiedApiJourneyException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }


    public class TflUnifiedApiJourneyException<TResult> : TflUnifiedApiJourneyException
    {
        public TResult Result { get; private set; }

        public TflUnifiedApiJourneyException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }


    public class TflUnifiedApiLineException : Exception
    {
        public string StatusCode { get; private set; }

        public string Response { get; private set; }

        public Dictionary<string, IEnumerable<string>> Headers { get; private set; }

        public TflUnifiedApiLineException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }


    public class TflUnifiedApiLineException<TResult> : TflUnifiedApiLineException
    {
        public TResult Result { get; private set; }

        public TflUnifiedApiLineException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }


    public class TflUnifiedApiModeException : Exception
    {
        public string StatusCode { get; private set; }

        public string Response { get; private set; }

        public Dictionary<string, IEnumerable<string>> Headers { get; private set; }

        public TflUnifiedApiModeException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }


    public class TflUnifiedApiModeException<TResult> : TflUnifiedApiModeException
    {
        public TResult Result { get; private set; }

        public TflUnifiedApiModeException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }


    public class TflUnifiedApiOccupancyException : Exception
    {
        public string StatusCode { get; private set; }

        public string Response { get; private set; }

        public Dictionary<string, IEnumerable<string>> Headers { get; private set; }

        public TflUnifiedApiOccupancyException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }


    public class TflUnifiedApiOccupancyException<TResult> : TflUnifiedApiOccupancyException
    {
        public TResult Result { get; private set; }

        public TflUnifiedApiOccupancyException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }


    public class TflUnifiedApiPlaceException : Exception
    {
        public string StatusCode { get; private set; }

        public string Response { get; private set; }

        public Dictionary<string, IEnumerable<string>> Headers { get; private set; }

        public TflUnifiedApiPlaceException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }


    public class TflUnifiedApiPlaceException<TResult> : TflUnifiedApiPlaceException
    {
        public TResult Result { get; private set; }

        public TflUnifiedApiPlaceException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }


    public class TflUnifiedApiRoadException : Exception
    {
        public string StatusCode { get; private set; }

        public string Response { get; private set; }

        public Dictionary<string, IEnumerable<string>> Headers { get; private set; }

        public TflUnifiedApiRoadException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }


    public class TflUnifiedApiRoadException<TResult> : TflUnifiedApiRoadException
    {
        public TResult Result { get; private set; }

        public TflUnifiedApiRoadException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }


    public class TflUnifiedApiSearchException : Exception
    {
        public string StatusCode { get; private set; }

        public string Response { get; private set; }

        public Dictionary<string, IEnumerable<string>> Headers { get; private set; }

        public TflUnifiedApiSearchException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }


    public class TflUnifiedApiSearchException<TResult> : TflUnifiedApiSearchException
    {
        public TResult Result { get; private set; }

        public TflUnifiedApiSearchException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }


    public class TflUnifiedApiStopPointException : Exception
    {
        public string StatusCode { get; private set; }

        public string Response { get; private set; }

        public Dictionary<string, IEnumerable<string>> Headers { get; private set; }

        public TflUnifiedApiStopPointException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }


    public class TflUnifiedApiStopPointException<TResult> : TflUnifiedApiStopPointException
    {
        public TResult Result { get; private set; }

        public TflUnifiedApiStopPointException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }


    public class TflUnifiedApiTravelTimeException : Exception
    {
        public string StatusCode { get; private set; }

        public string Response { get; private set; }

        public Dictionary<string, IEnumerable<string>> Headers { get; private set; }

        public TflUnifiedApiTravelTimeException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }


    public class TflUnifiedApiTravelTimeException<TResult> : TflUnifiedApiTravelTimeException
    {
        public TResult Result { get; private set; }

        public TflUnifiedApiTravelTimeException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }


    public class TflUnifiedApiVehicleException : Exception
    {
        public string StatusCode { get; private set; }

        public string Response { get; private set; }

        public Dictionary<string, IEnumerable<string>> Headers { get; private set; }

        public TflUnifiedApiVehicleException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }


    public class TflUnifiedApiVehicleException<TResult> : TflUnifiedApiVehicleException
    {
        public TResult Result { get; private set; }

        public TflUnifiedApiVehicleException(string message, string statusCode, string response, Dictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }
}

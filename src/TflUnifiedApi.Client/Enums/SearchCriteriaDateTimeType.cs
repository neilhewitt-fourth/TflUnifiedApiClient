using System.Runtime.Serialization;

namespace TflUnifiedApiClient
{
    public enum SearchCriteriaDateTimeType
    {
        [EnumMember(Value = "Arriving")]
        Arriving = 0,

        [EnumMember(Value = "Departing")]
        Departing = 1,

    }
}

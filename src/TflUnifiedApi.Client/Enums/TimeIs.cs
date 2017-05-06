using System.Runtime.Serialization;

namespace TflUnifiedApiClient
{
    public enum TimeIs
    {
        [EnumMember(Value = "Arriving")]
        Arriving = 0,

        [EnumMember(Value = "Departing")]
        Departing = 1,

    }
}

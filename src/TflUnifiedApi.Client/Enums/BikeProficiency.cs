using System.Runtime.Serialization;

namespace TflUnifiedApiClient
{
    public enum BikeProficiency
    {
        [EnumMember(Value = "Easy")]
        Easy = 0,

        [EnumMember(Value = "Moderate")]
        Moderate = 1,

        [EnumMember(Value = "Fast")]
        Fast = 2,

    }
}

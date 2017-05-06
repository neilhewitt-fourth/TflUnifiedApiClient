using System.Runtime.Serialization;

namespace TflUnifiedApiClient
{
    public enum StopPointSequenceServiceType
    {
        [EnumMember(Value = "Regular")]
        Regular = 0,

        [EnumMember(Value = "Night")]
        Night = 1,

    }
}

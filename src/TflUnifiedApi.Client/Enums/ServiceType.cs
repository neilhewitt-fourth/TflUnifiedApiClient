using System.Runtime.Serialization;

namespace TflUnifiedApiClient
{
    public enum ServiceType
    {
        [EnumMember(Value = "Regular")]
        Regular = 0,

        [EnumMember(Value = "Night")]
        Night = 1,

    }
}

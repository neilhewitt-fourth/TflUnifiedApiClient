using System.Runtime.Serialization;

namespace TflUnifiedApiClient
{
    public enum PeriodType
    {
        [EnumMember(Value = "Normal")]
        Normal = 0,

        [EnumMember(Value = "FrequencyHours")]
        FrequencyHours = 1,

        [EnumMember(Value = "FrequencyMinutes")]
        FrequencyMinutes = 2,

        [EnumMember(Value = "Unknown")]
        Unknown = 3,

    }
}

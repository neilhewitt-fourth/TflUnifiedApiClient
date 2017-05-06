using System.Runtime.Serialization;

namespace TflUnifiedApiClient
{
    /// <summary>The journey preference eg possible options: "leastinterchange" | "leasttime" | "leastwalking"</summary>

    public enum JourneyPreference
    {
        [EnumMember(Value = "LeastInterchange")]
        LeastInterchange = 0,

        [EnumMember(Value = "LeastTime")]
        LeastTime = 1,

        [EnumMember(Value = "LeastWalking")]
        LeastWalking = 2,

    }
}

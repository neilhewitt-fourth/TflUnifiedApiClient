using System.Runtime.Serialization;

namespace TflUnifiedApiClient
{
    /// <summary>The walking speed. eg possible options: "slow" | "average" | "fast".</summary>

    public enum WalkingSpeed
    {
        [EnumMember(Value = "Slow")]
        Slow = 0,

        [EnumMember(Value = "Average")]
        Average = 1,

        [EnumMember(Value = "Fast")]
        Fast = 2,

    }
}

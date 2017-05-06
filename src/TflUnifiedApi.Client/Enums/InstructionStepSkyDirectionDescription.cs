using System.Runtime.Serialization;

namespace TflUnifiedApiClient
{
    public enum InstructionStepSkyDirectionDescription
    {
        [EnumMember(Value = "North")]
        North = 0,

        [EnumMember(Value = "NorthEast")]
        NorthEast = 1,

        [EnumMember(Value = "East")]
        East = 2,

        [EnumMember(Value = "SouthEast")]
        SouthEast = 3,

        [EnumMember(Value = "South")]
        South = 4,

        [EnumMember(Value = "SouthWest")]
        SouthWest = 5,

        [EnumMember(Value = "West")]
        West = 6,

        [EnumMember(Value = "NorthWest")]
        NorthWest = 7,

    }
}

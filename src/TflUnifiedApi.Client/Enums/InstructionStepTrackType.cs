using System.Runtime.Serialization;

namespace TflUnifiedApiClient
{
    public enum InstructionStepTrackType
    {
        [EnumMember(Value = "CycleSuperHighway")]
        CycleSuperHighway = 0,

        [EnumMember(Value = "CanalTowpath")]
        CanalTowpath = 1,

        [EnumMember(Value = "QuietRoad")]
        QuietRoad = 2,

        [EnumMember(Value = "ProvisionForCyclists")]
        ProvisionForCyclists = 3,

        [EnumMember(Value = "BusyRoads")]
        BusyRoads = 4,

        [EnumMember(Value = "None")]
        None = 5,

        [EnumMember(Value = "PushBike")]
        PushBike = 6,

    }
}

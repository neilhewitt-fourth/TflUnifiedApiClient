using System.Runtime.Serialization;

namespace TflUnifiedApiClient
{
    public enum DisruptionCategory
    {
        [EnumMember(Value = "Undefined")]
        Undefined = 0,

        [EnumMember(Value = "RealTime")]
        RealTime = 1,

        [EnumMember(Value = "PlannedWork")]
        PlannedWork = 2,

        [EnumMember(Value = "Information")]
        Information = 3,

        [EnumMember(Value = "Event")]
        Event = 4,

        [EnumMember(Value = "Crowding")]
        Crowding = 5,

        [EnumMember(Value = "StatusAlert")]
        StatusAlert = 6,

    }
}

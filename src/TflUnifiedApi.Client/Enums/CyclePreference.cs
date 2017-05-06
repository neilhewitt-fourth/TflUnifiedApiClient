using System.Runtime.Serialization;

namespace TflUnifiedApiClient
{
    /// <summary>The cycle preference. eg possible options: "allTheWay" | "leaveAtStation" | "takeOnTransport" | "cycleHire"</summary>

    public enum CyclePreference
    {
        [EnumMember(Value = "None")]
        None = 0,

        [EnumMember(Value = "LeaveAtStation")]
        LeaveAtStation = 1,

        [EnumMember(Value = "TakeOnTransport")]
        TakeOnTransport = 2,

        [EnumMember(Value = "AllTheWay")]
        AllTheWay = 3,

        [EnumMember(Value = "CycleHire")]
        CycleHire = 4,

    }
}

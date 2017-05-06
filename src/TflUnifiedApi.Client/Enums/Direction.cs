using System.Runtime.Serialization;

namespace TflUnifiedApiClient
{
    /// <summary>The direction of travel. Can be inbound or outbound.</summary>

    public enum Direction
    {
        [EnumMember(Value = "inbound")]
        Inbound = 0,

        [EnumMember(Value = "outbound")]
        Outbound = 1,

        [EnumMember(Value = "all")]
        All = 2,

    }
}

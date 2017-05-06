using System.Runtime.Serialization;

namespace TflUnifiedApiClient
{
    /// <summary>The direction of travel.</summary>

    public enum OverlayDirection
    {
        [EnumMember(Value = "Average")]
        Average = 0,

        [EnumMember(Value = "From")]
        From = 1,

        [EnumMember(Value = "To")]
        To = 2,

    }
}

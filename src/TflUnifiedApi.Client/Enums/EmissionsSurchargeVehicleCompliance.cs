using System.Runtime.Serialization;

namespace TflUnifiedApiClient
{


    public enum EmissionsSurchargeVehicleCompliance
    {
        [EnumMember(Value = "NotCompliant")]
        NotCompliant = 0,

        [EnumMember(Value = "Compliant")]
        Compliant = 1,

        [EnumMember(Value = "Exempt")]
        Exempt = 2,

    }
}

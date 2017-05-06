using System.Runtime.Serialization;

namespace TflUnifiedApiClient
{
    public enum RoadProjectPhase
    {
        [EnumMember(Value = "Unscoped")]
        Unscoped = 0,

        [EnumMember(Value = "Concept")]
        Concept = 1,

        [EnumMember(Value = "ConsultationEnded")]
        ConsultationEnded = 2,

        [EnumMember(Value = "Consultation")]
        Consultation = 3,

        [EnumMember(Value = "Construction")]
        Construction = 4,

        [EnumMember(Value = "Complete")]
        Complete = 5,

    }
}

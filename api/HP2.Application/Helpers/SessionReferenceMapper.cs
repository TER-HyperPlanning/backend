using HP2.Domain.Enums;

namespace HP2.Application.Helpers;

public static class SessionReferenceMapper
{
    public static string ToLabel(SessionTypeEnum sessionType) => sessionType switch
    {
        SessionTypeEnum.CM => "CM",
        SessionTypeEnum.TD => "TD",
        SessionTypeEnum.TP => "TP",
        SessionTypeEnum.EXAMEN => "EXAMEN",
        SessionTypeEnum.SOUTENANCE => "SOUTENANCE",
        SessionTypeEnum.EVENEMENT => "EVENEMENT",
        _ => throw new ArgumentOutOfRangeException(nameof(sessionType), sessionType, null)
    };

    public static string ToLabel(SessionStatusEnum sessionStatus) => sessionStatus switch
    {
        SessionStatusEnum.PROGRAMME => "PROGRAMME",
        SessionStatusEnum.ANNULE => "ANNULE",
        SessionStatusEnum.DEPLACE => "DEPLACE",
        SessionStatusEnum.RATTRAPE => "RATTRAPE",
        _ => throw new ArgumentOutOfRangeException(nameof(sessionStatus), sessionStatus, null)
    };
    public static SessionTypeEnum ToSessionTypeEnum(string label) => label switch
    {
        "CM" => SessionTypeEnum.CM,
        "TD" => SessionTypeEnum.TD,
        "TP" => SessionTypeEnum.TP,
        "EXAMEN" => SessionTypeEnum.EXAMEN,
        "SOUTENANCE" => SessionTypeEnum.SOUTENANCE,
        "EVENEMENT" => SessionTypeEnum.EVENEMENT,
        _ => throw new ArgumentOutOfRangeException(nameof(label), label, null)
    };

    public static SessionStatusEnum ToSessionStatusEnum(string label) => label switch
    {
        "PROGRAMME" => SessionStatusEnum.PROGRAMME,
        "ANNULE" => SessionStatusEnum.ANNULE,
        "DEPLACE" => SessionStatusEnum.DEPLACE,
        "RATTRAPE" => SessionStatusEnum.RATTRAPE,
        _ => throw new ArgumentOutOfRangeException(nameof(label), label, null)
    };
}
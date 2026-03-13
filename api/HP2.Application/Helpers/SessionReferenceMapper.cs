using HP2.Domain.Enums;

namespace HP2.Application.Helpers;

public static class SessionReferenceMapper
{
    public static string ToLabel(SessionTypeEnum sessionType) => sessionType switch
    {
        SessionTypeEnum.CM => "CM",
        SessionTypeEnum.TD => "TD",
        SessionTypeEnum.TP => "TP",
        _ => throw new ArgumentOutOfRangeException(nameof(sessionType), sessionType, null)
    };

    public static string ToLabel(SessionStatusEnum sessionStatus) => sessionStatus switch
    {
        SessionStatusEnum.PROGRAMME => "Programmé",
        _ => throw new ArgumentOutOfRangeException(nameof(sessionStatus), sessionStatus, null)
    };
}
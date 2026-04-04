namespace HP2.Domain.Enums;

public static class UnavailableDayTypeMapper
{
    // Convertit l'enum vers la valeur DB
    public static string ToDbValue(UnavailableDayTypeEnum type)
    {
        return type switch
        {
            UnavailableDayTypeEnum.VACANCES => "TYPE1",
            UnavailableDayTypeEnum.FERIES => "TYPE2",
            _ => throw new ArgumentOutOfRangeException(nameof(type), "Type inconnu")
        };
    }

    // Convertit la valeur DB vers l'enum
    public static UnavailableDayTypeEnum FromDbValue(string dbValue)
    {
        return dbValue switch
        {
            "TYPE1" => UnavailableDayTypeEnum.VACANCES,
            "TYPE2" => UnavailableDayTypeEnum.FERIES,
            _ => throw new Exception($"Valeur DB inconnue : {dbValue}")
        };
    }
}
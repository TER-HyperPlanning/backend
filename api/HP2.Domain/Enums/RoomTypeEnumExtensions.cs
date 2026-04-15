using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace HP2.Domain.Enums
{
    public static class RoomTypeEnumExtensions
    {
        private static readonly Dictionary<string, RoomTypeEnum> _normalizedValues = new()
        {
            { "salletd", RoomTypeEnum.SalleTD },
            { "salledetd", RoomTypeEnum.SalleTD },
            { "sallecours", RoomTypeEnum.SalleCOURS },
            { "salledecours", RoomTypeEnum.SalleCOURS },
            { "amphitheatre", RoomTypeEnum.AMPHITHEATRE }
        };

        public static RoomTypeEnum ParseRoomType(string value)
        {
            if (TryParseRoomType(value, out var roomType))
            {
                return roomType;
            }

            throw new System.ArgumentException($"La valeur '{value}' ne correspond à aucun RoomTypeEnum connu.", nameof(value));
        }

        private static readonly Dictionary<string, RoomTypeEnum> _roomTypeIds = new(StringComparer.OrdinalIgnoreCase)
        {
            { "2ebbc802-19e3-1c66-7809-e0126364f9f3", RoomTypeEnum.SalleTD }
        };

        public static bool TryParseRoomType(string value, out RoomTypeEnum roomType)
        {
            roomType = default;

            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            if (System.Enum.TryParse<RoomTypeEnum>(value, true, out roomType))
            {
                return true;
            }

            if (_roomTypeIds.TryGetValue(value.Trim(), out roomType))
            {
                return true;
            }

            var normalized = Normalize(value);
            return _normalizedValues.TryGetValue(normalized, out roomType);
        }

        public static string ToRoomTypeName(this RoomTypeEnum roomType)
        {
            return roomType switch
            {
                RoomTypeEnum.SalleTD => "Salle de TD",
                RoomTypeEnum.SalleCOURS => "Salle de cours",
                RoomTypeEnum.AMPHITHEATRE => "Amphithéâtre",
                _ => roomType.ToString()
            };
        }

        private static string Normalize(string value)
        {
            var normalized = value.Trim().ToLowerInvariant();
            normalized = normalized.Normalize(NormalizationForm.FormD);
            normalized = string.Concat(normalized.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark));
            normalized = string.Concat(normalized.Where(c => !char.IsWhiteSpace(c) && c != '-' && c != '_'));
            return normalized;
        }
    }
}

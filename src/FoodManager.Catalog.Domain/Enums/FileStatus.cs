using System.Text.Json.Serialization;

namespace FoodManager.Catalog.Domain.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum FileStatus
{
    InProgress,
    Failed,
    Concluded
}
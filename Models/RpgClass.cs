using System.Text.Json.Serialization;

namespace First_API.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3,
        Dwarf = 4,
        Elf = 5,
        Hobbit = 6,
        Ranger = 7,
    }
}
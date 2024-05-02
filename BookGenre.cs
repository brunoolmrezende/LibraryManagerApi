using System.Runtime.Serialization;

namespace LibraryManagerApi;

public enum BookGenre
{
    [EnumMember(Value = "Fiction")]
    Fiction,

    [EnumMember(Value = "NonFiction")]
    NonFiction,

    [EnumMember(Value = "Mystery")]
    Mystery,

    [EnumMember(Value = "Romance")]
    Romance,

    [EnumMember(Value = "Fantasy")]
    Fantasy,

}

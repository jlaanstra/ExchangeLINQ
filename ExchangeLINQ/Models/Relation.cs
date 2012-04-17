using System.Runtime.Serialization;

namespace ExchangeLINQ.Models
{
    /// <summary>
    /// one of parent, meta, or chat
    /// </summary>
    public enum Relation
    {
        [EnumMember(Value = "parent")]
        Parent,
        [EnumMember(Value = "meta")]
        Meta,
        [EnumMember(Value = "chat")]
        Chat
    }
}

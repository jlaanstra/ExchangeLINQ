using System.Runtime.Serialization;

namespace ExchangeLINQ.Models
{
	public enum UserType
	{
		[EnumMember(Value="unregistered")]
		Unregistered,

		[EnumMember(Value="registered")]
		Registered,

		[EnumMember(Value="moderator")]
		Moderator,

		[EnumMember(Value="does_not_exist")]
		None
	}
}

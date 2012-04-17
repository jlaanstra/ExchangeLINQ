using System.Runtime.Serialization;

namespace ExchangeLINQ.Models
{
	public enum PostType
	{
		[EnumMember(Value="question")]
		Question,

		[EnumMember(Value="answer")]
		Answer
	}
}

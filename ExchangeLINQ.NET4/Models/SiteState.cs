using System.Runtime.Serialization;

namespace ExchangeLINQ.Models
{
	/// <summary>
	/// normal, closed_beta, open_beta, or linked_meta
	/// </summary>
	public enum SiteState
	{
		[EnumMember(Value = "normal")]
		Normal,

		[EnumMember(Value = "closed_beta")]
		ClosedBeta,

		[EnumMember(Value = "open_beta")]
		OpenBeta,

		[EnumMember(Value = "linked_meta")]
		LinkedMeta
	}
}


namespace ExchangeLINQ.Context
{
	/// <summary>
	/// Represents a site specific context.
	/// </summary>
	public interface ISite
	{
		/// <summary>
		/// Gets or sets the current StackExchange site API parameter.
		/// </summary>
		string ApiSiteParameter { get; set; }
	}
}

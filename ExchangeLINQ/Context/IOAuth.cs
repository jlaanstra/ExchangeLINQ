
namespace ExchangeLINQ.Context
{
	/// <summary>
	/// Represents a context that has an access token and key.
	/// </summary>
	public interface IOAuth
	{
		/// <summary>
		/// Gets or sets the authentication token.
		/// </summary>
		string AccessToken { get; set; }

		/// <summary>
		/// Gets or sets the authentication key.
		/// </summary>
		string Key { get; set; }
	}
}

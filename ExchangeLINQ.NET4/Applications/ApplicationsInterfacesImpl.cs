using System;
using System.Collections.Generic;
using System.Linq;

namespace ExchangeLINQ.Applications
{
    public class ApplicationsInterfacesImpl : IApplicationsDeauthenticate, IApplicationsToken, IApplicationsIn
    {
        /// <summary>
        /// Deauthenticates this instance.
        /// </summary>
        public void Deauthenticate() { }

        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
		public IApplicationsIn Token { get { return this; } }

        /// <summary>
        /// Ins the specified tokens.
        /// </summary>
        /// <param name="tokens">The tokens.</param>
        /// <returns></returns>
        public IEnumerable<string> In(params string[] tokens)
        {
            return In(tokens.AsEnumerable());
        }

        /// <summary>
        /// Ins the specified tokens.
        /// </summary>
        /// <param name="tokens">The tokens.</param>
        /// <returns></returns>
        public IEnumerable<string> In(IEnumerable<string> tokens)
        {
            if (tokens.Count() > 20)
            {
                throw new ArgumentException("You can specify a maximum of 20 tokens");
            }
            return tokens;
        }
    }
}

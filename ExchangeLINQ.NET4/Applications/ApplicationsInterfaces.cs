using System.Collections.Generic;
using ExchangeLINQ.Common.Types;

namespace ExchangeLINQ.Applications
{
    public interface IApplicationsDeauthenticate
    {
        FilterDeauthenticate Deauthenticate { get; }
    }

    public interface IApplicationsToken
    {
        InProp<FilterTokens, string> Token { get; }
    }
}

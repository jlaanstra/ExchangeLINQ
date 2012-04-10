using System.Collections.Generic;

namespace ExchangeLINQ.Applications
{
    public interface IApplicationsDeauthenticate
    {
        void Deauthenticate();
    }

    public interface IApplicationsToken
    {
        IApplicationsIn Token { get; }
    }

    public interface IApplicationsIn
    {
        IEnumerable<string> In(params string[] tokens);

        IEnumerable<string> In(IEnumerable<string> tokens);
    }
}

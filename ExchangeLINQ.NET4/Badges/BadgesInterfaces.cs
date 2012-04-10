using System.Collections.Generic;

namespace ExchangeLINQ.Badges
{
    public interface IBadgesIn
    {
        /// <summary>
        /// Method added to hook into the c# params syntax.
        /// </summary>
        /// <param name="tokens">The tokens.</param>
        /// <returns></returns>
        IEnumerable<int> In(params int[] ids);

        /// <summary>
        /// Specified to enable intellisense in LINQ query.
        /// </summary>
        /// <param name="tokens">The tokens.</param>
        /// <returns></returns>
        IEnumerable<int> In(IEnumerable<int> ids);
    }
}

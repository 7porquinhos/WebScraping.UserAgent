using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraping.UserAgent.Core.Interfaces
{
    public interface IUserAgent
    {
        /// <summary>
        /// Get the browser's user agent.
        /// </summary>
        /// <param></param>
        /// <returns>
        /// String containing the user agent.
        /// </returns>
        /// <exception cref="Exception">
        /// </exception>
        string UserAgentBrowser();
    }
}

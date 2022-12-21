using WebScraping.UserAgent.Core.Interfaces;

namespace WebScraping.UserAgent.Core
{
    public sealed class BrowserUserAgent
    {
        public string UserAgent { get;}
        public BrowserUserAgent() => this.UserAgent = new UserAgentBase().UserAgentBrowser();
    }
}
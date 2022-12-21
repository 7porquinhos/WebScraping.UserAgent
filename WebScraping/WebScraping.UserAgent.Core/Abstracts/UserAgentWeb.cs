using HtmlAgilityPack;
using WebScraping.UserAgent.Core.Interfaces;

namespace WebScraping.UserAgent.Core.Abstracts
{
    public abstract class UserAgentWeb : IUserAgent
    {
        public string UserAgentBrowser()
        {
            string userAgentText = "";
            // From Web
            var url = "https://www.whatismybrowser.com/pt/detect/what-is-my-user-agent/";
            var web = new HtmlWeb();
            var doc = web.Load(url);

            foreach (var item in doc.DocumentNode.SelectNodes("//*[@id=\"detected_value\"]"))
            {
                userAgentText = item.InnerText;
            }
            return userAgentText;
        }
    }
}

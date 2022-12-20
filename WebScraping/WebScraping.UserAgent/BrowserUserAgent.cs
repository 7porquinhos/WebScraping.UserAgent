using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebScraping.UserAgent.Interfaces;

namespace WebScraping.UserAgent
{
    public sealed class BrowserUserAgent : IUserAgent
    {
        /// <inheritdoc/>
        public string UserAgentBrowser => UserAgentService();

        private string UserAgentService()
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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebScraping.UserAgent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraping.UserAgent.Tests
{
    [TestClass()]
    public class BrowserUserAgentTests
    {
        [TestMethod()]
        public void UserAgentBrowserTest()
        {
            Assert.IsTrue(!string.IsNullOrEmpty(new BrowserUserAgent().UserAgentBrowser));
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebScraping.UserAgent.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraping.UserAgent.Core.Abstracts.Tests
{
    [TestClass()]
    public class UserAgentWebTests
    {
        [TestMethod()]
        public void UserAgentBrowserTest()
        {
            BrowserUserAgent browserUserAgent = new BrowserUserAgent();

            Assert.IsTrue(!string.IsNullOrEmpty(browserUserAgent.UserAgent));
        }
    }
}
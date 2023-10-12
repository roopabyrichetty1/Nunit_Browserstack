using NUnit.Framework;
using OpenQA.Selenium;
using System.Text.RegularExpressions;

namespace BrowserStack
{
  [TestFixture]
  [Category("sample-local-test")]
  public class SampleLocalTest : BrowserStackNUnitTest
  {
    public SampleLocalTest() : base() { }

    [Test]
    public void BStackTunnelCheck()
    {
      driver.Navigate().GoToUrl("https://www.bentley.com/");
      StringAssert.Contains("Home | Bentley | Infrastructure Engineering Software", driver.Title);
    }
  }
}

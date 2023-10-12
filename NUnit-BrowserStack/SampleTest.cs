using NUnit.Framework;
using OpenQA.Selenium;

namespace BrowserStack
{
    [TestFixture]
    [Category("sample-test")]
    public class SampleTest : BrowserStackNUnitTest
    {
        public SampleTest() : base() { }

        [Test]
        public void SearchBstackDemo()
        {
            driver.Navigate().GoToUrl("https://www.bentley.com/");
            Assert.AreEqual("Home | Bentley | Infrastructure Engineering Software", driver.Title);          
            
        }
    }
}

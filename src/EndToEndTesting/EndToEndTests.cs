using NUnit.Framework;

namespace EndToEndTesting
{
    [TestClass]
    public class EndToEndTests : PageTest
    {
        [TestMethod]
        public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
        {
            await Page.GotoAsync("https://localhost:7237");

            // Expect a title "to contain" a substring.
            await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

            // create a locator
            var getStarted = Page.Locator("text=Get Started");

            // Expect an attribute "to be strictly equal" to the value.
            await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

            // Click the get started link.
            await getStarted.ClickAsync();

            // Expects the URL to contain intro.
            await Expect(Page).ToHaveURLAsync(new Regex(".*intro"));
        }
        [Test]
        public async Task Test1()
        {
            const string pageTitle = "Calculator";

            await Page.GotoAsync("https://localhost:7237/");

            await Expect(Page).ToHaveTitleAsync(pageTitle);
        }
        //cutting losses
    }
}

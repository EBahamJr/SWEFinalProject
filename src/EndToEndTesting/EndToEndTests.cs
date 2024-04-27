using Microsoft.Playwright;
using NUnit.Framework;

namespace EndToEndTesting
{
    [TestClass]
    public class EndToEndTests : PageTest
    {
        [TestMethod]
        //preq-E2E-TEST-5
        public async Task CalculatorFrontEnd_TabName_Calculator()
        {
            await Page.GotoAsync("http://localhost:5079/");
            await Expect(Page).ToHaveTitleAsync(new Regex("Calculator"));            
        }

        [TestMethod]
        //preq-E2E-TEST-6
        public async Task CalculatorFrontEnd_AdditonFunction_ShowsCorrectExpression()
        {
            await Page.GotoAsync("http://localhost:5079/");

            var inputA = Page.Locator("id=Anum");
            var inputB = Page.Locator("id=Bnum");
            var add = Page.GetByText("A + B");
            var results = Page.Locator("id=Results");

            await inputA.FillAsync("5");
            await inputB.FillAsync("3");
            await add.ClickAsync();

            await Expect(results).ToContainTextAsync("5 + 3 = 8");
        }

        [TestMethod]
        //preq-E2E-TEST-7
        public async Task CalculatorFrontEnd_DivisionFunction_ReturnsNaN()
        {
            await Page.GotoAsync("http://localhost:5079/");

            var inputA = Page.Locator("id=Anum");
            var inputB = Page.Locator("id=Bnum");
            var add = Page.GetByText("A / B");
            var results = Page.Locator("id=Results");

            await inputA.FillAsync("5");
            await inputB.FillAsync("0");
            await add.ClickAsync();

            await Expect(results).ToContainTextAsync("Not a Number");
        }

        [TestMethod]
        //preq-E2E-TEST-8
        public async Task CalculatorFrontEnd_BadInput_ReturnsInvalid()
        {
            await Page.GotoAsync("http://localhost:5079/");

            var inputA = Page.Locator("id=Anum");
            var inputB = Page.Locator("id=Bnum");
            var divide = Page.GetByText("A / B");
            var results = Page.Locator("id=Results");

            await inputA.FillAsync("5");
            await inputB.FillAsync("fifteen");
            await divide.ClickAsync();

            await Expect(results).ToContainTextAsync("Invalid Input, Numbers Only");
        }

        [TestMethod]
        //preq-E2E-TEST-8
        public async Task CalculatorFrontEnd_ClearButton_DefaultState()
        {
            await Page.GotoAsync("http://localhost:5079/");

            var inputA = Page.Locator("id=Anum");
            var inputB = Page.Locator("id=Bnum");
            var add = Page.GetByText("A + B");
            var clear = Page.GetByText("clear");
            var results = Page.Locator("id=Results");

            await inputA.FillAsync("5");
            await inputB.FillAsync("5");
            await add.ClickAsync();
            await clear.ClickAsync();

            await Expect(results).ToContainTextAsync("Enter value(s) below and select an operation.");
        }
    }
}

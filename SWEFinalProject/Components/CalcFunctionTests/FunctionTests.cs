using NUnit.Framework;
using SWEFinalProject.Components.Functions;

namespace SWEFinalProject.Components.CalcFunctionTests
{
    public class FunctionTests
    {
        public int result = 0;
        CalculatorFunctions functions = new();
        [SetUp]
        public void Setup()
        {
            functions = new CalculatorFunctions();
        }
        private void FormatShortcut(float A, float B)
        {
            functions.SetA(A);
            functions.SetB(B);
        }

        [Test]
        public void CalcAddTest1()
        {
            //Testing the Addition Function
            FormatShortcut(1, 2);
            functions.CalcAdd();
            Assert.That(3f == functions.GetResult());
        }
    }
}

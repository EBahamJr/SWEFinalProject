using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTesting.CalcFunctions
{
    internal class CalculatorTests
    {
        public int result = 0;
        CalculatorFunctions functions;
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

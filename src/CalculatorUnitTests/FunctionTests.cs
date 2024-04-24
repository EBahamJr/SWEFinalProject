public class FunctionTests
{
    public int result = 0;
    CalculatorFunctions functions = new();
    [SetUp]
    public void Setup()
    {
        functions = new CalculatorFunctions();
    }
    private void FormatShortcut(double A, double B)
    {
        functions.SetA(A);
        functions.SetB(B);

    }

    //A and B Functions
    [Test]
    public void CalcAddTest1() //Coverage Testing additon
    {
        FormatShortcut(5.5f, -3.15f);
        functions.CalcAdd();
        Assert.That(2.35f == functions.GetResult());
    }

    [Test]
    public void CalcSubTest1() //Coverage Testing Subtraction
    {
        FormatShortcut(27.93f, 4f);
        functions.CalcSubtract();
        Assert.That(23.93f == functions.GetResult());
    }

    [Test]
    public void CalcMultTest1() // Testing a middle of the road test case
    {
        FormatShortcut(8.5f, 2);
        functions.CalcMultiply();
        Assert.That(17f == functions.GetResult());
    }
    [Test]
    public void CalcMultTest2() // Testing a middle of the road test case with negative numbers
    {
        FormatShortcut(8.5f, -2);
        functions.CalcMultiply();
        Assert.That(-17f == functions.GetResult());
    }

    [Test]
    public void CalcDivTest1() // Testing middle of the road test case
    {
        FormatShortcut(3, 9);
        functions.CalcDivide();
        Assert.That(0.33333333f == functions.GetResult());
    }
    [Test]
    public void CalcDivTest2() //Testing input of 0 on b
    {
        FormatShortcut(8, 0);
        functions.CalcDivide();
        Assert.That(0f == functions.GetResult());
    }
    [Test]
    public void CalcDivTest3() //Testing input of 0 on a
    {
        FormatShortcut(0, 1);
        functions.CalcDivide();
        Assert.That(0f == functions.GetResult());
    }

    [Test]
    public void CalcEqualsTest1() //Checking Equals test limit
    {
        FormatShortcut(0.333333331f, 0.333333332f);
        functions.CalcEquals();
        Assert.That(1f == functions.GetResult());
    }
    [Test]
    public void CalcEqualsTest2() //Checking Equals test limit
    {
        FormatShortcut(0.33333334d, 0.33333333d);
        functions.CalcEquals();
        Assert.That(0f == functions.GetResult());
    }

    [Test]
    public void CalcPowTest1() //Checking Pow Test Positive b
    {
        FormatShortcut(2, 3);
        functions.CalcPow();
        Assert.That(8f == functions.GetResult());
    }
    [Test]
    public void CalcPowTest2() //Checking Pow Test Larger a
    {
        FormatShortcut(5, 2);
        functions.CalcPow();
        Assert.That(25f == functions.GetResult());
    }
    [Test]
    public void CalcPowTest3() //Checking Pow Test Negative b
    {
        FormatShortcut(5, -3);
        functions.CalcPow();
        Assert.That(0.008 == functions.GetResult());
    }

    [Test]
    public void CalcLogTest3() //Checking Log Test Negative b
    {
        FormatShortcut(8, 2);
        functions.CalcLog();
        Assert.That(3 == functions.GetResult()); //not done
    }
    //A only Functions
}
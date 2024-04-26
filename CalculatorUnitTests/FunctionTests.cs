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
    //preq-UNIT-TEST-2
    public void CalcAdd_Doubles_ReturnCorrect() //Coverage Testing additon
    {
        //Arrange
        FormatShortcut(5.5f, -3.15f);
        //Act
        functions.CalcAdd();
        //Assert
        Assert.That(2.35f == functions.GetResult());
    }

    [Test]
    //preq-UNIT-TEST-3
    public void CalcSubtract_Doubles_ReturnCorrect() //Coverage Testing Subtraction
    {
        //Arrange
        FormatShortcut(27.93f, 4f);
        //Act
        functions.CalcSubtract();
        //Assert
        Assert.That(23.93f == functions.GetResult());
    }

    [Test]
    //preq-UNIT-TEST-4
    public void CalcMultiply_Doubles_ReturnCorrect() // Testing a middle of the road test case
    {
        //Arrange
        FormatShortcut(8.5f, 2);
        //Act
        functions.CalcMultiply();
        //Assert
        Assert.That(17f == functions.GetResult());
    }

    [Test]
    //preq-UNIT-TEST-5
    public void CalcDivide_Doubles_ReturnCorrect() // Testing middle of the road test case
    {
        //Arrange
        FormatShortcut(3, 9);
        //Act
        functions.CalcDivide();
        //Assert
        Assert.That(0.33333333f == functions.GetResult());
    }
    [Test]
    //preq-UNIT-TEST-6
    public void CalcDivide_DivideBy0_ReturnNaN() //Testing input of 0 on b
    {
        //Arrange
        FormatShortcut(8, 0);
        //Act
        functions.CalcDivide();
        //Assert
        Assert.That(double.IsNaN(functions.GetResult()));//returns double.NaN
    }
    [Test]
    public void CalcDivide_DivideZeroByNumber_ReturnCorrect() //Testing input of 0 on a
    {
        //Arrange
        FormatShortcut(0, 1);
        //Act
        functions.CalcDivide();
        //Assert
        Assert.That(0f == functions.GetResult());
    }

    [Test]
    //preq-UNIT-TEST-7
    public void CalcEquals_Doubles_ReturnTrueToEightDigits() //Checking Equals test limit
    {
        //Arrange
        FormatShortcut(0.333333331f, 0.333333332f);
        //Act
        functions.CalcEquals();
        //Assert
        Assert.That(1f == functions.GetResult());
    }
    [Test]
    public void CalcEquals_Doubles_ReturnFalseToSevenDigits() //Checking Equals test limit
    {
        //Arrange
        FormatShortcut(0.33333334d, 0.33333333d);
        //Act
        functions.CalcEquals();
        //Assert
        Assert.That(0f == functions.GetResult());
    }

    [Test]
    //preq-UNIT-TEST-8
    public void CalcPow_Doubles_ReturnCorrect() //Checking Pow Test Positive b
    {
        //Arrange
        FormatShortcut(2, 3);
        //Act
        functions.CalcPow();
        //Assert
        Assert.That(8f == functions.GetResult());
    }
    [Test]
    public void CalcPow_NegativeDoubles_ReturnCorrect() //Checking Pow Test Negative b
    {
        //Arrange
        FormatShortcut(5, -3);
        //Act
        functions.CalcPow();
        //Assert
        Assert.That(0.008 == functions.GetResult());
    }

    [Test]
    //preq-UNIT-TEST-9
    public void CalcLog_Doubles_ReturnCorrect() //Checking Log Test Positive b
    {
        //Arrange
        FormatShortcut(8, 2);
        //Act
        functions.CalcLog();
        //Assert
        Assert.That(3 == functions.GetResult());
    }
    [Test]
    //preq-UNIT-TEST-10
    public void CalcLog_ZeroA_ReturnNaN() //Checking Log Test Positive b
    {
        //Arrange
        FormatShortcut(0, 2);
        //Act
        functions.CalcLog();
        //Assert
        Assert.That(double.IsNaN(functions.GetResult()));//automatically returns NaN
    }
    [Test]
    //preq-UNIT-TEST-11
    public void CalcLog_ZeroB_ReturnNaN() //Checking Log Test Positive b
    {
        //Arrange
        FormatShortcut(8, 0);
        //Act
        functions.CalcLog();
        //Assert
        Assert.That(double.IsNaN(functions.GetResult()));//automatically return NaN
    }

    [Test]
    //preq-UNIT-TEST-12
    public void CalcRoot_Doubles_ReturnCorrect() //Checking Root Test  b
    {
        //Arrange
        FormatShortcut(8, 3);
        //Act
        functions.CalcRoot();
        //Assert
        Assert.That(2 == functions.GetResult());
    }
    [Test]
    //preq-UNIT-TEST-13
    public void CalcRoot_ZeroB_ReturnNaN() //Checking Root Test  b
    {
        //Arrange
        FormatShortcut(8, 0);
        //Act
        functions.CalcRoot();
        //Assert
        Assert.That(double.IsNaN(functions.GetResult()));
    }

    //A only Functions
    [Test]
    //preq-UNIT-TEST-14
    public void CalcFactorial_Double_ReturnCorrect() //Checking Factorial Test for A
    {
        //Arrange
        functions.SetA(5);
        //Act
        functions.CalcFactorial();
        //Assert
        Assert.That(120 == functions.GetResult());
    }
    [Test]
    public void CalcFactorial_NegativeDouble_ReturnCorrect() //Checking Factorial Test for Negative A
    {
        //Arrange
        functions.SetA(-5);
        //Act
        functions.CalcFactorial();
        //Assert
        Assert.That(-120 == functions.GetResult());
    }
    [Test]
    //preq-UNIT-TEST-15
    public void CalcFactorial_Zero_ReturnOne() //Checking Factorial Test for 0
    {
        //Arrange
        functions.SetA(0);
        //Act
        functions.CalcFactorial();
        //Assert
        Assert.That(1 == functions.GetResult());
    }

    [Test]
    //preq-UNIT-TEST-16
    public void CalcSin_Double_ReturnCorrect() //Checking Sin Test for Negative A
    {
        //Arrange
        functions.SetA(360);
        //Act
        functions.CalcSin();
        //Assert
        Assert.That(0 == functions.GetResult());
    }
    [Test]
    public void CalcSin_Negative360_ReturnCorrect() //Checking Sin Test for Negative A
    {
        //Arrange
        functions.SetA(-360);
        //Act
        functions.CalcSin();
        //Assert
        Assert.That(0 == functions.GetResult());
    }

    [Test]
    public void CalcSin_Zero_ReturnCorrect() //Checking Sin Test for Negative A
    {
        //Arrange
        functions.SetA(0);
        //Act
        functions.CalcSin();
        //Assert
        Assert.That(0 == functions.GetResult());
    }

    [Test]
    public void CalcSin_One_ReturnCorrect() //Checking Sin Test for Negative A
    {
        //Arrange
        functions.SetA(1);
        //Act
        functions.CalcSin();
        //Assert
        Assert.That(0.017452405765652657 == functions.GetResult());
    }

    [Test]
    //preq-UNIT-TEST-17
    public void CalcCos_Double_ReturnCorrect() //Checking Cos Test for Negative A
    {
        //Arrange
        functions.SetA(360);
        //Act
        functions.CalcCos();
        //Assert
        Assert.That(1 == functions.GetResult());
    }
    [Test]
    public void CalcCos_Negtive360_ReturnCorrect() //Checking Cos Test for Negative A
    {
        //Arrange
        functions.SetA(-360);
        //Act
        functions.CalcCos();
        //Assert
        Assert.That(1 == functions.GetResult());
    }
    [Test]
    public void CalcCos_Zero_ReturnCorrect() //Checking Cos Test for Negative A
    {
        //Arrange
        functions.SetA(0);
        //Act
        functions.CalcCos();
        //Assert
        Assert.That(1 == functions.GetResult());
    }
    [Test]
    public void CalcCos_One_ReturnCorrect() //Checking Cos Test for Negative A
    {
        //Arrange
        functions.SetA(1);
        //Act
        functions.CalcCos();
        //Assert
        Assert.That(0.9998477101325989 == functions.GetResult());
    }

    [Test]
    //preq-UNIT-TEST-18
    public void CalcTan_Double_ReturnCorrect() //Checking Tan Test for Negative A
    {
        //Arrange
        functions.SetA(360);
        //Act
        functions.CalcTan();
        //Assert
        Assert.That(0 == functions.GetResult());
    }
    [Test]
    public void CalcTan_Negative360_ReturnCorrect() //Checking Tan Test for Negative A
    {
        //Arrange
        functions.SetA(-360);
        //Act
        functions.CalcTan();
        //Assert
        Assert.That(0 == functions.GetResult());
    }
    [Test]
    public void CalcTan_Zero_ReturnCorrect() //Checking Tan Test for Negative A
    {
        //Arrange
        functions.SetA(0);
        //Act
        functions.CalcTan();
        //Assert
        Assert.That(0 == functions.GetResult());
    }
    [Test]
    public void CalcTan_One_ReturnCorrect() //Checking Tan Test for Negative A
    {
        //Arrange
        functions.SetA(1);
        //Act
        functions.CalcTan();
        //Assert
        Assert.That(0.01745506562292576 == functions.GetResult());
    }

    [Test]
    //preq-UNIT-TEST-19
    public void CalcInverse_Double_ReturnCorrect() //Checking Tan Test for Negative A
    {
        //Arrange
        functions.SetA(8);
        //Act
        functions.CalcNegate();
        //Assert
        Assert.That(0.125 == functions.GetResult());
    }
    [Test]
    public void CalcInverse_Negative_ReturnCorrect() //Checking Tan Test for Negative A
    {
        //Arrange
        functions.SetA(-4);
        //Act
        functions.CalcNegate();
        //Assert
        Assert.That(-0.25 == functions.GetResult());
    }
    [Test]
    //preq-UNIT-TEST-20
    public void CalcInverse_Zero_ReturnNaN() //Checking Tan Test for Negative A
    {
        //Arrange
        functions.SetA(0);
        //Act
        functions.CalcNegate();
        //Assert
        Assert.That(double.IsNaN(functions.GetResult()));
    }
}
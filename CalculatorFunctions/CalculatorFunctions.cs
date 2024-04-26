using System;
using System.Diagnostics;

public class CalculatorFunctions
{
    /*This program works as follows to allow the calcualtor to store and use data effectively. Set X, select the operation, set Y, then run the problem  */


    private double a;
    private double b;

    private double result;
    //getter and setters
    public double GetResult()
    {
        return result;
    }
    public void SetA(double a)
    {
        this.a = a;
    }
    public void SetB(double b)
    {
        this.b = b;
    }
    public double GetA()
    {
        return a;
    }
    public double GetB()
    {
        return b;
    }


    //Functions to test
    //A and B function
    public double CalcAdd()// +
    {
        //preq-ENGINE-3
        result = a + b;
        return result;
    }

    public double CalcSubtract()// -
    {
        //preq-ENGINE-4
        result = a - b;
        return result;
    }

    public double CalcMultiply()//*
    {
        //preq-ENGINE-5
        result = a * b;
        return result;
    }

    public double CalcDivide()// /
    {
        //preq-ENGINE-7
        if (b == 0)
        {
            result = double.NaN; ;
            return result;
        }
        else
        {
            result = (float)(a / b);
        }
        return result;
    }

    public double CalcEquals()// ==
    {
        //preq-ENGINE-8
        string tempA = a.ToString("0.00000000");
        string tempB = b.ToString("0.00000000");
        if (tempA == tempB)
        {
            result = 1;
        }
        else
        {
            result = 0;
        }
        return result;
    }

    public double CalcPow()// ^
    {
        //preq-ENGINE-9
        result = Math.Pow(a, b);
        return result;
    }

    public double CalcLog()// log
    {
        //preq-ENGINE-10
        if (a != 0 && b != 0)
        {
            result = Math.Log(a, b);
        }
        else
        {
            result = double.NaN;
        }
        return result;
    }

    public double CalcRoot()// root
    {
        //preq-ENGINE-11
        if (b != 0)
        {
            result = Math.Pow(a, 1 / b);
        }
        else
        {
            result = double.NaN;
        }
        return result;
    }

    //A only Function
    public double CalcFactorial()// ! factorial
    {
        //preq-ENGINE-12
        result = 1;
        if (a != 0)
        {
            //factorials can't be decimals
            int x = (int)a;

            for (int i = 0; i < Math.Abs(x); i++)
            {
                result *= Math.Abs(x) - i;
            }

            if (a < 0 && x%2 != 0)
            {
                result = -result;
            }
        }
        Console.WriteLine(result.ToString());
        return result;
    }

    public double CalcSin()// sin
    {
        //preq-ENGINE-13
        if (Math.Abs(a) != 360)
        {
            float r = MathF.Sin((float)(a * Math.PI / 180));
            result = float.Parse(r.ToString());
            Console.WriteLine(result);
        }
        else
        {
            result = 0;
        }
        return Math.Round(result);
    }

    public double CalcCos()// cos
    {
        //preq-ENGINE-14
        if (Math.Abs(a) != 360)
        {
            float r = MathF.Cos((float)(a * Math.PI / 180));
            result = float.Parse(r.ToString());
            Console.WriteLine(result);
        }
        else
        {
            result = 1;
        }
        return result;
    }

    // tan
    public double CalcTan()// tan
    {
        //preq-ENGINE-15
        if (Math.Abs(a) != 360)
        {
            float r = MathF.Tan((float)(a * Math.PI / 180));
            result = float.Parse(r.ToString());
            Console.WriteLine(result);
        }
        else
        {
            result = 0;
        }
        return result;
    }

    // 1/A
    public double CalcNegate()// 1/a
    {
        //preq-ENGINE-16
        if (a == 0)
        {
            result = double.NaN;
        }
        else
        {
            result = 1 / a;
        }
        return result;
    }
}


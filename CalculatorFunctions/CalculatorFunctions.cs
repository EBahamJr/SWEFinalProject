﻿using System;
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
        result = a + b;
        return result;
    }

    public double CalcSubtract()// -
    {
        result = a - b;
        return result;
    }

    public double CalcMultiply()//*
    {
        result = a * b;
        return result;
    }

    public double CalcDivide()// /
    {
        if (b == 0)
        {
            result = 0;
            return 0;
        }
        else
        {
            result = (float)(a / b);
        }
        return result;
    }

    public double CalcEquals()// ==
    {
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
        result = Math.Pow(a, b);
        return result;
    }

    public double CalcLog()// log
    {
        result = Math.Log(a, b);
        return result;
    }

    public double CalcRoot()// root
    {
        result = Math.Pow(a, 1 / b);
        return result;
    }

    //A only Function
    public double CalcFactorial()// ! factorial
    {
        result = 1;
        if (a != 0)
        {
            //factorials can't be decimals
            int x = (int)a;

            for (int i = 0; i < x; i--)
            {
                result *= x - i;
            }
        }
        return result;
    }

    public double CalcSin()// sin
    {
        result = Math.Sin(a);
        return result;
    }

    public double CalcCos()// cos
    {
        result = Math.Cos(a);
        return result;
    }

    // tan
    public double CalcTan()// tan
    {
        result = Math.Tan(a);
        return result;
    }

    // 1/A
    public double CalcNegate()// 1/a
    {
        result = 1/a;
        return result;
    }
}


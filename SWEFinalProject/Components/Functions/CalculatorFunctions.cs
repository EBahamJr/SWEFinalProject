using System;
using System.Diagnostics;

namespace SWEFinalProject.Components.Functions
{
    public class CalculatorFunctions
    {
        /*This program works as follows to allow the calcualtor to store and use data effectively. Set X, select the operation, set Y, then run the problem  */


        private double a;
        private double b;

        private double result;
        //getter and setters
        public double GetResult()
        {
            return this.result;
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
            //result = a / b;
            result = Math.Log(a, b);
            return result;
        }

        public double CalcRoot()// root
        {
            //result = a / b;
            result = Math.Pow(a, 1/b);
            return result;
        }

        //A only Function

        // !

        // sin

        // cos

        // tan

        // 1/A
    }
}

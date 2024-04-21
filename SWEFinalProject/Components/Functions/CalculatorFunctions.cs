namespace SWEFinalProject.Components.Functions
{
    public class CalculatorFunctions
    {
        /*This program works as follows to allow the calcualtor to store and use data effectively. Set X, select the operation, set Y, then run the problem  */


        private float a;
        private float b;

        private float result;
        //getter and setters
        public float GetResult()
        {
            return this.result;
        }
        public void SetA(float a)
        {
            this.a = a;
        }
        public void SetB(float b)
        {
            this.b = b;
        }
        public float GetA()
        {
            return a;
        }
        public float GetB()
        {
            return b;
        }


        //Functions to test
        //A and B function
        public float CalcAdd()// +
        {
            result = a + b;
            return result;
        }

        public float CalcSubtract()// -
        {
            result = a - b;
            return result;
        }

        public float CalcMultiply()//*
        {
            result = a * b;
            return result;
        }

        public float CalcDivide()// /
        {
            result = a / b;
            return result;
        }
        
        public float CalcEquals()// ==
        {
            //result = a / b;
            return result;
        }

        public float CalcPow()// ^
        {
            //result = a / b;
            return result;
        }

        public float CalcLog()// log
        {
            //result = a / b;
            return result;
        }

        public float CalcSqRoot()// root
        {
            //result = a / b;
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

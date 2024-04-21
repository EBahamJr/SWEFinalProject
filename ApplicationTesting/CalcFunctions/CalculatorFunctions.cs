using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTesting.CalcFunctions
{
    internal class CalculatorFunctions
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
        public void CalcAdd()
        {
            result = a + b;
        }
    }
}

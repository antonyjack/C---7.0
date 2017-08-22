using System;

namespace Tuples_Enhancement
{
    public class Example
    {
        public Example(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
        public int Num1 {get;}
        public int Num2{get;}

        public void Deconstruct(out int num1, out int num2, out string message)
        {
            num1 = this.Num1;
            num2 = this.Num2;
            message = "Deconstruct method implemented";
        }

        public (int, int) GroupFunction()
        {
            int add = this.Num1 + this.Num2;
            int mul = this.Num1 * this.Num2;
            return(add, mul);
        }
    }
}
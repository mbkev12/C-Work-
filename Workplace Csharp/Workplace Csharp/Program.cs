using System;

namespace Workplace_Csharp
{
    public class Multiplication
    {
        public int Multiply(int Num1, int Num2, int Num3)
        {
            return Num1 + Num2 + Num3;
        }
        public int Multiply(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Multiplication dataClass = new Multiplication();
            int add2 = dataClass.Multiply(45, 34, 67);
            int add1 = dataClass.Multiply(23, 34);
        }
    }

}


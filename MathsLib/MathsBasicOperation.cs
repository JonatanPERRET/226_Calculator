using System;

namespace MathsLib
{
    public class MathsBasicOperation
    {
        #region public methods
        public int Add(int op1, int op2)
        {
            return op1 + op2;
        }

        public int Substract(int op1, int op2)
        {
            return op1 - op2;
        }

        public int Multiply(int op1, int op2)
        {
            return op1 * op2;
        }

        public int Divide(int op1, int op2)
        {
            return op1 / op2;
        }
        #endregion
    }
}

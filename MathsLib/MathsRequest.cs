using System;

namespace MathsLib
{
    public class MathsRequest
    {
        #region private variables
        int _op1;
        int _op2;
        char _oper;
        #endregion
        #region public methods
        public MathsRequest(int op1, char oper, int op2)
        {
            _op1 = op1;
            _oper = oper;
            _op2 = op2;
        }

        public int Op1
        {
            get
            {
                return _op1;
            }
        }
        public char Oper
        {
            get
            {
                return _oper;
            }
        }

        public int Op2
        {
            get
            {
                return _op2;
            }
        }
        
        #endregion
    }
}

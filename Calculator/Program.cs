using System;
using MathsLib;
namespace Calculator
{
    class Program
    {
        /// <summary>
        /// This method is the entry point of the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Variables declaration
            int result;
            int op1;
            int op2;
            char oper;
            #endregion Variables declaration

            MathsBasicOperation _maths = new MathsBasicOperation();

            oper = AskUserForCharInput("Enter operator");

            while (oper != '#')
            {
                #region User inputs and variables initialization
                op1 = AskUserForIntegerInput("Enter first operand");
                op2 = AskUserForIntegerInput("Enter second operand");

                #endregion User input and variable initialization

                #region Perform calculations
                switch (oper)
                {
                    case ('+'):
                        result =  _maths.Add(op1, op2);
                        break;
                    case ('-'):
                        result = _maths.Substract(op1, op2);
                        break;
                    case ('*'):
                        result = _maths.Multiply(op1, op2);
                        break;
                    case ('/'):
                        result = _maths.Divide(op1, op2);
                        break;
                    default:
                        DisplayMessage("Operator not supported");
                        goto End;
                }

                #endregion Perform calculations

                #region Display result
                DisplayResult(op1, oper, op2, result);
                #endregion Display result

                oper = AskUserForCharInput("Enter operator");
            }
            End:
            DisplayMessage("You choose to leave...");
        }

        #region GUI
        static private char AskUserForCharInput(string question)
        {
            Console.WriteLine(question);
            return Char.Parse(Console.ReadLine());
        }

        static private int AskUserForIntegerInput(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }

        static private void DisplayResult(int op1, char oper, int op2, int result)
        {
            Console.WriteLine("The result of " + op1 + " " + oper + " " + op2 + " is : " + result);
        }

        static private void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        #endregion GUI
    }
}

using System;
using System.ComponentModel;

namespace BE.MathTasks.Artihmetics
{
    public static class ArithmeticOperatorsExtensions
    {
        public static string ToSymbol(this ArithmeticOperators operators)
        {
            return operators switch
            {
                ArithmeticOperators.Addition => "+",
                ArithmeticOperators.Subtraction => "-",
                ArithmeticOperators.Multiplication => "*",
                ArithmeticOperators.Divison => "/",
                _ => throw new ArgumentOutOfRangeException(nameof(operators), operators, null)
            };
        }

        public static string ToDisplaySymbol(this ArithmeticOperators operators)
        {
            string op = ToSymbol(operators)
                .Replace("/", "÷").Replace("*", "×");

            return op;
        }
    }
}
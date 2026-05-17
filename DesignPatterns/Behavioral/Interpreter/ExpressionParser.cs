using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Interpreter
{
    /// <summary>
    /// Simple parser that converts a basic arithmetic string into an expression tree.
    /// </summary>
    public static class ExpressionParser
    {
        public static IExpression Parse(string expression)
        {
            var tokens = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length == 0)
            {
                throw new ArgumentException("Expression cannot be empty.");
            }

            IExpression current = new NumberExpression(int.Parse(tokens[0]));

            for (int i = 1; i < tokens.Length; i += 2)
            {
                string op = tokens[i];
                int value = int.Parse(tokens[i + 1]);
                var right = new NumberExpression(value);

                current = op switch
                {
                    "+" => new AddExpression(current, right),
                    "-" => new SubtractExpression(current, right),
                    _ => throw new InvalidOperationException($"Unsupported operator '{op}'.")
                };
            }

            return current;
        }
    }
}
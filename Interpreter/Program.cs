using Interpreter.Expression;
using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AbstractExpression> obj = new List<AbstractExpression>();
            Context context = new Context(Console.ReadLine());
            string[] parts = context.Expression.Split(' ');

            foreach (string exp in parts)
            {
                if (exp == "MM")
                {
                    obj.Add(new MonthExpression());
                }
                else if (exp == "DD")
                {
                    obj.Add(new DayExpression());
                }
                else if (exp == "YYYY")
                {
                    obj.Add(new YearExpression());
                }
            }

            obj.Add(new SeparatorExpression());

            foreach (AbstractExpression exp in obj)
            {
                exp.Evaluate(context);
            }

            Console.WriteLine(context.Expression);
        }
    }
}

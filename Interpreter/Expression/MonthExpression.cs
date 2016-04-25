using System;

namespace Interpreter.Expression
{
    public class MonthExpression : AbstractExpression
    {
        public override void Evaluate(Context obj)
        {
            string temp = obj.Expression;
            obj.Expression = obj.Expression.Replace("MM", DateTime.Now.Month.ToString());
        }
    }
}

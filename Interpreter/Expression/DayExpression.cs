using System;

namespace Interpreter.Expression
{
    public class DayExpression : AbstractExpression
    {
        public override void Evaluate(Context obj)
        {
            string temp = obj.Expression;
            obj.Expression = obj.Expression.Replace("DD", DateTime.Now.Day.ToString());
        }
    }
}

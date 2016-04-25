using System;

namespace Interpreter.Expression
{
    public class YearExpression : AbstractExpression
    {
        public override void Evaluate(Context obj)
        {
            string temp = obj.Expression;
            obj.Expression = obj.Expression.Replace("YYYY", DateTime.Now.Year.ToString());
        }
    }
}

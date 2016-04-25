namespace Interpreter.Expression
{
    public class SeparatorExpression : AbstractExpression
    {
        public override void Evaluate(Context obj)
        {
            string temp = obj.Expression;
            obj.Expression = obj.Expression.Replace(" ", "-");
        }
    }
}

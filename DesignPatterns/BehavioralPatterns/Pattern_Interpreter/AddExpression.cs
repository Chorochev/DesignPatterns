
namespace DesignPatterns.BehavioralPatterns.Pattern_Interpreter
{
    /// <summary>
    /// NonterminalExpression: нетерминальное выражение, представляет правило грамматики. Для каждого 
    /// отдельного правила грамматики создается свой объект NonterminalExpression.
    /// нетерминальное выражение для сложения.
    /// </summary>
    class AddExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;

        public AddExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        public int Interpret(Context context)
        {
            return leftExpression.Interpret(context) + rightExpression.Interpret(context);
        }
    }
}

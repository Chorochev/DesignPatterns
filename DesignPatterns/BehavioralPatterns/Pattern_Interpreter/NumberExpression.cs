
namespace DesignPatterns.BehavioralPatterns.Pattern_Interpreter
{
    /// <summary>
    /// TerminalExpression: терминальное выражение, реализует метод Interpret() для терминальных символов 
    /// грамматики. Для каждого символа грамматики создается свой объект TerminalExpression.
    /// терминальное выражение.
    /// </summary>
    class NumberExpression : IExpression
    {
        string name; // имя переменной
        public NumberExpression(string variableName)
        {
            name = variableName;
        }
        public int Interpret(Context context)
        {
            return context.GetVariable(name);
        }
    }
}

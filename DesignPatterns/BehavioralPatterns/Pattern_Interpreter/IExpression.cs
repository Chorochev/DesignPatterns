
namespace DesignPatterns.BehavioralPatterns.Pattern_Interpreter
{
    /// <summary>
    /// AbstractExpression: определяет интерфейс выражения, объявляет метод Interpret()
    /// </summary>
    interface IExpression
    {
        int Interpret(Context context);
    }
}


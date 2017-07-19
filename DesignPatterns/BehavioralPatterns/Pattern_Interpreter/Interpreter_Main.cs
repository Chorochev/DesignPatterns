using System;

namespace DesignPatterns.BehavioralPatterns.Pattern_Interpreter
{
    public static class Interpreter_Main
    {
        public static void Go()
        {
            Context context = new Context();
            // определяем набор переменных
            int x = 5;
            int y = 8;
            int z = 2;

            // добавляем переменные в контекст
            context.SetVariable("x", x);
            context.SetVariable("y", y);
            context.SetVariable("z", z);
            // создаем объект для вычисления выражения x + y - z
            var xxx = new NumberExpression("x");
            var yyy = new NumberExpression("y");
            var left = new AddExpression(xxx, yyy);
            var right = new NumberExpression("z");
            IExpression expression = new SubtractExpression(left, right);

            int result = expression.Interpret(context);
            Console.WriteLine("результат: {0}", result);

            IExpression expression2 = new AddExpression(xxx, yyy);
            int result2 = expression2.Interpret(context);
            Console.WriteLine("результат2: {0}", result2);

            Console.Read();
        }
    }
}

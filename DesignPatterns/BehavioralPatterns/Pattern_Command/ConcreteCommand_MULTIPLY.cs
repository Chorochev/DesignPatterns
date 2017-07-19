using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Pattern_Command
{
    /// <summary>
    /// ConcreteCommand_SUM: конкретная реализация команды, реализует метод Execute(), 
    /// в котором вызывается определенный метод, определенный в классе Receiver.
    /// Умножение.
    /// </summary>
    class ConcreteCommand_MULTIPLY : Command
    {
        /// <summary>
        /// Множитель
        /// </summary>
        public int operand { get; private set; }
        /// <summary>
        /// Receiver: получатель команды.
        /// </summary>
        Calculator calculator;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="calculator">Receiver: получатель команды.</param>
        /// <param name="operand">множитель</param>
        public ConcreteCommand_MULTIPLY(Calculator calculator, int operand)
        {
            this.calculator = calculator;
            this.operand = operand;
        }
        /// <summary>
        /// Выполнение операции
        /// </summary>
        public override void Execute()
        {
            calculator.Operation('*', operand);
        }
        /// <summary>
        /// Отмена выполненной операции
        /// </summary>
        public override void UnExecute()
        {
            calculator.Operation('/', operand);
        }
    }
}

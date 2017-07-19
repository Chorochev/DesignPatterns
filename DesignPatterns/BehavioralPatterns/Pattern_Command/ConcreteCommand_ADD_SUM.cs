
namespace DesignPatterns.BehavioralPatterns.Pattern_Command
{
    /// <summary>
    /// ConcreteCommand_SUM: конкретная реализация команды, реализует метод Execute(), 
    /// в котором вызывается определенный метод, определенный в классе Receiver.
    /// Добавление суммы.
    /// </summary>
    class ConcreteCommand_ADD_SUM : Command
    {       
        /// <summary>
        /// Добавочное значение
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
        /// <param name="operand">добавочное значение</param>
        public ConcreteCommand_ADD_SUM(Calculator calculator, int operand)
        {
            this.calculator = calculator;            
            this.operand = operand;
        }
        /// <summary>
        /// Выполнение операции
        /// </summary>
        public override void Execute()
        {
            calculator.Operation('+', operand);
        }
        /// <summary>
        /// Отмена выполненной операции
        /// </summary>
        public override void UnExecute()
        {
            calculator.Operation('-', operand);
        }
    }

}

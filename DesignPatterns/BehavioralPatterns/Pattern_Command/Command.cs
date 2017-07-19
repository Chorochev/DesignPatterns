
namespace DesignPatterns.BehavioralPatterns.Pattern_Command
{
    /// <summary>
    /// Command: интерфейс, представляющий команду. Обычно определяет метод Execute() для выполнения 
    /// действия, а также нередко включает метод UnExecute(), реализация которого должна заключаться 
    /// в отмене действия команды.
    /// </summary>
    abstract class Command
    {
        /// <summary>
        /// Выполнение действия команды
        /// </summary>
        public abstract void Execute();
        /// <summary>
        /// Отмена действия комманды
        /// </summary>
        public abstract void UnExecute();
    }
}

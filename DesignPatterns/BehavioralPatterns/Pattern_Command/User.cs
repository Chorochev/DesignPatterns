using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Pattern_Command
{
    /// <summary>
    /// Invoker: инициатор команды - вызывает команду для выполнения определенного запроса.
    /// </summary>
    class User
    {
        /// <summary>
        /// Receiver: получатель команды. Определяет действия, которые должны выполняться в результате запроса.
        /// </summary>
        private Calculator _calculator = new Calculator();
        /// <summary>
        /// Коллекция команд
        /// </summary>
        private List<Command> _commands = new List<Command>();
        /// <summary>
        /// Указатель на операцию
        /// </summary>
        private int _current = 0;

        /// <summary>
        /// Делаем возврат операций
        /// </summary>
        /// <param name="levels"></param>
        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);
            // Делаем возврат операций
            for (int i = 0; i < levels; i++)
            {
                if (_current < _commands.Count) _commands[_current++].Execute();
            }
        }
        /// <summary>
        /// Делаем отмену операций
        /// </summary>
        /// <param name="levels"></param>
        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);
            // Делаем отмену операций
            for (int i = 0; i < levels; i++)
            {
                if (_current > 0) _commands[--_current].UnExecute();
            }
        }
        /// <summary>
        /// Создаем команду операции и выполняем её
        /// </summary>
        /// <param name="operand">слогаемое</param>
        public void Compute_ADD_SUMM(int operand)
        {
            // Создаем команду операции и выполняем её
            Command command = new ConcreteCommand_ADD_SUM(_calculator, operand);
            command.Execute();

            if (_current < _commands.Count)
            {
                // если "внутри undo" мы запускаем новую операцию, 
                // надо обрубать список команд, следующих после текущей, 
                // иначе undo/redo будут некорректны
                _commands.RemoveRange(_current, _commands.Count - _current);
            }

            // Добавляем операцию к списку отмены
            _commands.Add(command);
            _current++;
        }

        /// <summary>
        /// Создаем команду операции и выполняем её
        /// </summary>
        /// <param name="operand">множитель</param>
        public void Compute_MULTIPLY(int operand)
        {
            // Создаем команду операции и выполняем её
            Command command = new ConcreteCommand_MULTIPLY(_calculator, operand);
            command.Execute();

            if (_current < _commands.Count)
            {
                // если "внутри undo" мы запускаем новую операцию, 
                // надо обрубать список команд, следующих после текущей, 
                // иначе undo/redo будут некорректны
                _commands.RemoveRange(_current, _commands.Count - _current);
            }

            // Добавляем операцию к списку отмены
            _commands.Add(command);
            _current++;
        }
    }
}

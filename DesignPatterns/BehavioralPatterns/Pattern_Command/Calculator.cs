using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Pattern_Command
{
    /// <summary>
    /// Receiver: получатель команды. Определяет действия, которые должны выполняться в результате запроса.
    /// </summary>
    class Calculator
    {
        /// <summary>
        /// Текущее значение
        /// </summary>
        private int curr = 0;
       
        /// <summary>
        /// Операция
        /// </summary>
        /// <param name="operator">тип оператора</param>
        /// <param name="operand">операнд</param>
        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': curr += operand; break;
                case '-': curr -= operand; break;
                case '*': curr *= operand; break;
                case '/': curr /= operand; break;
            }
            Console.WriteLine("Current value = {0,3} (following {1} {2})", curr, @operator, operand);
        }
    }
}

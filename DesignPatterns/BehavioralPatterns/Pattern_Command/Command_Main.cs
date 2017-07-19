using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Pattern_Command
{
    public static class Command_Main
    {
        public static void Go()
        {
            // Создаем пользователя.
            User user = new User();

            // Пусть он что-нибудь сделает.
            user.Compute_ADD_SUMM(100);
            user.Compute_ADD_SUMM(50);
            user.Compute_MULTIPLY(5);
            user.Compute_ADD_SUMM(200);
            user.Compute_MULTIPLY(3);
            // Отменяем 4 команды
            user.Undo(4);
            // Вернём 3 отменённые команды.
            user.Redo(3);
            // Ждем ввода пользователя и завершаемся.
            Console.Read();
        }
    }
}

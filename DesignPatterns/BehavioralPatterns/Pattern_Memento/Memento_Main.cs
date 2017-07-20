using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Pattern_Memento
{
    public static class Memento_Main
    {
        public static void Go()
        {
            Hero hero = new Hero();
            hero.Shoot(); // делаем выстрел, осталось 9 патронов

            GameHistory game = new GameHistory();
            game.History.Push(hero.SaveState()); // сохраняем игру

            hero.Shoot(); //делаем выстрел, осталось 8 патронов
            hero.Shoot(); //делаем выстрел, осталось 7 патронов
            hero.Shoot(); //делаем выстрел, осталось 6 патронов

            hero.RestoreState(game.History.Pop());
            hero.Shoot(); //делаем выстрел, осталось 8 патронов

            Console.Read();
        }
    }
}

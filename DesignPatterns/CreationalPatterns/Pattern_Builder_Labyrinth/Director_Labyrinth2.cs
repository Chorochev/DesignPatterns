using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_Builder_Labyrinth
{
    class Director_Labyrinth2
    {
        Builder_Labyrinth _Builder_Labyrinth;

        public Director_Labyrinth2(Builder_Labyrinth builder)
        {
            _Builder_Labyrinth = builder;
        }
        /// <summary>
        /// Создаем лабиринт
        /// </summary>
        public void Construct()
        {
            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 25; x++)
                {
                    int max = DateTime.Now.Millisecond;
                    int halfMax = max / 2;
                    Random rnd1 = new Random(DateTime.Now.Millisecond);
                    Thread.Sleep(10);
                    int val = rnd1.Next(max);
                    if (val >= halfMax)
                        _Builder_Labyrinth.CreateVoid(x, y);
                    else
                        _Builder_Labyrinth.CreateWall(x, y);
                }
                Thread.Sleep(3);
            }
        }
    }
}

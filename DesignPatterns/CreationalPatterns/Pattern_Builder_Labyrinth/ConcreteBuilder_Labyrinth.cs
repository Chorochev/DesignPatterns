using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_Builder_Labyrinth
{
    class ConcreteBuilder_Labyrinth : Builder_Labyrinth
    {
        /// <summary>
        /// класс с лабиринтом
        /// </summary>
        private Product_Labyrinth _Product_Labyrinth;
        /// <summary>
        /// Символ пустого места лабиринта
        /// </summary>
        private char ValueVoid;
        /// <summary>
        /// Символ стены лабиринта
        /// </summary>
        private char ValueWall;

        public ConcreteBuilder_Labyrinth()
        {
            _Product_Labyrinth = new Product_Labyrinth();           
            ValueVoid = ' ';
            ValueWall = '*';
        }
        /// <summary>
        /// Создание пустого места в лабиринте
        /// </summary>
        public override void CreateVoid(int x, int y)
        {
            _Product_Labyrinth.AddItem(new LabyrinthItem { X = x, Y = y, Value = ValueVoid });
        }
        /// <summary>
        /// Создание стены в лабиринте
        /// </summary>
        public override void CreateWall(int x, int y)
        {
            _Product_Labyrinth.AddItem(new LabyrinthItem { X = x, Y = y, Value = ValueWall });
        }
       
        /// <summary>
        /// Конструирование лабиринта
        /// </summary>
        /// <returns></returns>
        public override Product_Labyrinth GetResult()
        {            
            return _Product_Labyrinth;
        }
    }
}

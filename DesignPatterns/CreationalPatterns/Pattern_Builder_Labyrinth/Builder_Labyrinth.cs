using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_Builder_Labyrinth
{
    /// <summary>
    /// Интерфейс для создания лабиринта
    /// </summary>
    abstract class Builder_Labyrinth
    {        
        /// <summary>
        /// Создание стены
        /// </summary>
        public abstract void CreateWall(int x, int y);
        /// <summary>
        /// Создание пустого места
        /// </summary>
        public abstract void CreateVoid(int x, int y);
        /// <summary>
        /// Получение класса с лабиринтом
        /// </summary>
        /// <returns></returns>
        public abstract Product_Labyrinth GetResult();
    }
}

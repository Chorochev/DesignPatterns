using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Pattern_Builder_Labyrinth
{
    /// <summary>
    /// Лабиринт
    /// </summary>
    class Product_Labyrinth
    {
        /// <summary>
        /// Пустое мето для лабирита по умолчанию
        /// </summary>
        public char DefaultItem { get; private set; }

        /// <summary>
        /// Хранилище элементов лабиринта
        /// </summary>
        List<LabyrinthItem> Items;

        public Product_Labyrinth()
        {
            Items = new List<LabyrinthItem>();
            DefaultItem = ' ';
        }
        /// <summary>
        /// Добавление элемента в лабиринт
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(LabyrinthItem item)
        {
            if (Items.Count > 0)
            {
                if (!Items.Contains(item)) Items.Add(item);
            }
            else
                Items.Add(item);
        }
        /// <summary>
        /// Получение лабиринта в виде текстовых строк
        /// </summary>
        /// <returns></returns>
        public List<string> GetLines()
        {
            List<string> result = new List<string>();
            if (Items.Count > 0)
            {
                int maxX = Items.Max(s => s.X);
                int maxY = Items.Max(s => s.Y);
                for (int y = 0; y < maxY; y++)
                {                    
                    result.Add(GetLine(y, maxX));
                }
            }
            return result;
        }
        /// <summary>
        /// Получение строки лабиринта
        /// </summary>
        /// <param name="y">номер строки</param>
        /// <param name="maxX">максимальное значение длинны по оси Х</param>
        /// <returns></returns>
        public string GetLine(int y, int maxX = 0)
        {
            string result = string.Empty;
            int maxLoop = maxX > 0 ? maxX : Items.Where(s => s.Y == y).Max(t => t.X);            
            for (int x = 0; x < maxLoop; x++)
            {
                var currentItem = Items.Where(s => s.X == x && s.Y == y);
                result += (currentItem.Count() > 0) ? currentItem.First().Value.ToString() : DefaultItem.ToString();
            }
            return result;
        }

    }
    /// <summary>
    /// Элемент лабиринта
    /// </summary>
    public struct LabyrinthItem
    {
        /// <summary>
        /// Номер ячейки лабиринта по оси Х
        /// </summary>
        public int X;
        /// <summary>
        /// Номер ячейки лабиринта по оси Y
        /// </summary>
        public int Y;
        /// <summary>
        /// Значение лабиринта
        /// </summary>
        public char Value;
    }
}

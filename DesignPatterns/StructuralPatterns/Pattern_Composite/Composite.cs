using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Composite
{
    /// <summary>
    /// Составной объект у которого есть потомки.
    /// </summary>
    class Composite : Component
    {
        /// <summary>
        /// Колекция компонентов
        /// </summary>
        private List<Component> children = new List<Component>();

        // Constructor
        public Composite(TypeComponent type, string name) : base(type, name)
        {
        }

        /// <summary>
        /// Добавление компонента в текущий компонент
        /// </summary>
        /// <param name="component"></param>
        public void Add(Component component)
        {
            children.Add(component);
        }
        /// <summary>
        /// Удаление компонента из текущего компонента
        /// </summary>
        /// <param name="component"></param>
        public void Remove(Component component)
        {
            children.Remove(component);
        }
        /// <summary>
        /// Печать компонентов
        /// </summary>
        /// <param name="depth"></param>
        public override void Print(int depth)
        {
            System.Console.WriteLine("{0}{1}:{2}", TabSpace(depth), Type.ToString(), Name);

            // Recursively display child nodes
            foreach (Component component in children)
            {
                component.Print(depth + 2);
            }
        }       
    }
}

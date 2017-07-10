using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Composite
{
    /// <summary>
    /// Определение интерфейса для всех компонентов в древовидной структуре.
    /// </summary>
    abstract class Component
    {        
        /// <summary>
        /// Наименование компонента
        /// </summary>
        protected string Name;
        /// <summary>
        /// Тип компонента
        /// </summary>
        protected TypeComponent Type;

        public Component(TypeComponent type, string name)
        {
            this.Type = type;
            this.Name = name;            
        }

        public abstract void Print(int depth);

        /// <summary>
        /// Отступ
        /// </summary>
        /// <param name="size">количество прбелов</param>
        /// <returns></returns>
        protected string TabSpace(int size)
        {
            StringBuilder resulr = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                resulr.Append(" ");
            }
            return resulr.ToString();
        }
    }
}

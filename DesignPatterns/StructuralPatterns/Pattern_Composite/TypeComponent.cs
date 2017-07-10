using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Composite
{
    /// <summary>
    /// Типы компонентов БД
    /// </summary>
    enum TypeComponent
    {
        /// <summary>
        /// База данных.
        /// </summary>
        DataBase,
        /// <summary>
        /// Пространство имен.
        /// </summary>
        Namespace,
        /// <summary>
        /// Таблица БД.
        /// </summary>
        Table,
        /// <summary>
        /// Поле таблицы БД.
        /// </summary>
        Column
    }
}

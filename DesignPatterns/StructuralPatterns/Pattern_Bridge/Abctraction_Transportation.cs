using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Bridge
{
    /// <summary>
    /// Базовый интерфейс который хранит ссылку на объект Implementor. 
    /// Выполнение операций в Abstraction делегируется методам объекта Implementor.
    /// В данном случае этот класс обозначает транспортную компанию по перевозкам.
    /// </summary>
    abstract class Abctraction_Transportation
    {
        /// <summary>
        /// Машина
        /// </summary>
        protected Implementor_ICar car;
        /// <summary>
        /// Установка машины
        /// </summary>
        /// <param name="car">машина</param>
        /// <returns></returns>
        public Abctraction_Transportation SetCar(Implementor_ICar car)
        {
            this.car = car;
            return this;
        }
        /// <summary>
        /// Транспортная компания
        /// </summary>        
        public Abctraction_Transportation()
        {            
        }
        /// <summary>
        /// Произвести перевозку
        /// </summary>
        /// <param name="startPath">пункт отправления</param>
        /// <param name="endPath">пункт назначения</param>
        public virtual void DoWork(string startPath, string endPath)
        {
            car.StartPath = startPath;
            car.EndPath = endPath;
            car.Calling();
            car.Loading();
            car.Transportation();           
            car.Unloading();            
        }
        /// <summary>
        /// Заработанные деньги.
        /// </summary>
        public abstract void EarnMoney();
    }
}

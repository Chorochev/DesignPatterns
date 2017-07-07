using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Bridge
{
    /// <summary>    
    /// Конкретная реализация "Abctraction" 
    /// В данном случае это конкретная реализация транспортной компании по перевозкам.
    /// </summary>
    class RefinedAbstraction_Transportation : Abctraction_Transportation
    {
        /// <summary>
        /// Деньги компании
        /// </summary>
        public double Money { get; set; }

        public RefinedAbstraction_Transportation(double money)
        {
            Money = money;
        }
        /// <summary>
        /// Оплата
        /// </summary>
        /// <param name="money"></param>
        public void AddMoney(double money)
        {
            Money += money;
        }
        /// <summary>
        /// Заработок
        /// </summary>
        public override void EarnMoney()
        {
            System.Console.WriteLine("Заработок : {0}", Money);
        }
    }
}

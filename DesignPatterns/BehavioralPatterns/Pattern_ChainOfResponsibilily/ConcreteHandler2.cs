using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Pattern_ChainOfResponsibilily
{
    /// <summary>
    /// ConcreteHandler2: конкретный обработчик, который реализует функционал для обработки запроса. 
    /// При невозможности обработки и наличия ссылки на следующий обработчик, передают запрос 
    /// этому обработчику.
    /// </summary>
    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}

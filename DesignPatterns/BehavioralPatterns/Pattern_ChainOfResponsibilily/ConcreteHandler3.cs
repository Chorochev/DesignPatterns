using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Pattern_ChainOfResponsibilily
{
    /// <summary>
    /// ConcreteHandler3: конкретный обработчик, который реализует функционал для обработки запроса. 
    /// При невозможности обработки и наличия ссылки на следующий обработчик, передают запрос 
    /// этому обработчику.
    /// </summary>
    class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
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

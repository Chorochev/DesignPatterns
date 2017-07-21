using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Pattern_Visitor
{
    public class Visitor_Main
    {
        public static void Go()
        {
            var structure = new ObjectStructure_Bank();
            structure.Add(new Element_Person { Name = "Иван Алексеев", Number = "82184931" });
            structure.Add(new Element_Company { Name = "Microsoft", RegNumber = "ewuir32141324", Number = "3424131445" });
            Console.WriteLine("----ConcreteVisitor_ToHTML-----");
            structure.Accept(new ConcreteVisitor_ToHTML());
            Console.WriteLine("----ConcreteVisitor_ToXML-----");
            structure.Accept(new ConcreteVisitor_ToXML());            
            Console.WriteLine("----------------------------------------");
            Console.Read();
        }
    }
}

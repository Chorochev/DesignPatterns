using System;

namespace DesignPatterns.BehavioralPatterns.Pattern_Visitor
{
    /// <summary>
    /// ConcreteVisitor: конкретные классы посетителей, реализуют интерфейс, определенный в Visitor.
    /// </summary>
    class ConcreteVisitor_ToXML : IVisitor
    {
        public void VisitPersonAcc(Element_Person acc)
        {
            Console.WriteLine("---- Element_Person ----");
            string result = "<Person><Name>" + acc.Name + "</Name>" +
                "<Number>" + acc.Number + "</Number><Person>";
            Console.WriteLine(result);
        }

        public void VisitCompanyAc(Element_Company acc)
        {
            Console.WriteLine("---- Element_Company ----");
            string result = "<Company><Name>" + acc.Name + "</Name>" +
                "<RegNumber>" + acc.RegNumber + "</RegNumber>" +
                "<Number>" + acc.Number + "</Number><Company>";
            Console.WriteLine(result);
        }
    }

}

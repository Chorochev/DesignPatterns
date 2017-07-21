using System;

namespace DesignPatterns.BehavioralPatterns.Pattern_Visitor
{
    /// <summary>
    /// ConcreteVisitor: конкретные классы посетителей, реализуют интерфейс, определенный в Visitor.
    /// </summary>
    class ConcreteVisitor_ToHTML : IVisitor
    {
        public void VisitPersonAcc(Element_Person acc)
        {
            Console.WriteLine("---- Element_Person ----");
            string result = "<table><tr><td>Свойство<td><td>Значение</td></tr>";
            result += "<tr><td>Name<td><td>" + acc.Name + "</td></tr>";
            result += "<tr><td>Number<td><td>" + acc.Number + "</td></tr></table>";
            Console.WriteLine(result);
            Console.WriteLine();
        }

        public void VisitCompanyAc(Element_Company acc)
        {
            Console.WriteLine("---- Element_Company ----");
            string result = "<table><tr><td>Свойство<td><td>Значение</td></tr>";
            result += "<tr><td>Name<td><td>" + acc.Name + "</td></tr>";
            result += "<tr><td>RegNumber<td><td>" + acc.RegNumber + "</td></tr>";
            result += "<tr><td>Number<td><td>" + acc.Number + "</td></tr></table>";
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}

namespace DesignPatterns.BehavioralPatterns.Pattern_Visitor
{
    /// <summary>
    /// IVisitor: интерфейс посетителя, который определяет метод Visit() для каждого объекта Element
    /// </summary>
    interface IVisitor
    {
        void VisitPersonAcc(Element_Person acc);
        void VisitCompanyAc(Element_Company acc);
    }
}

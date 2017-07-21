namespace DesignPatterns.BehavioralPatterns.Pattern_Visitor
{
    /// <summary>
    /// Element:  Конкретный элемент, который реализует метод Accept()
    /// </summary>
    class Element_Person : IElement_Account
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitPersonAcc(this);
        }
    }
}

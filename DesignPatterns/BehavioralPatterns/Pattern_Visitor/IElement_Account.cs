namespace DesignPatterns.BehavioralPatterns.Pattern_Visitor
{
    /// <summary>
    /// IElement: определяет метод Accept(), в котором в качестве параметра принимается объект Visitor
    /// </summary>
    interface IElement_Account
    {
        void Accept(IVisitor visitor);
    }
}

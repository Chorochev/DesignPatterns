using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Pattern_Visitor
{
    /// <summary>
    /// ObjectStructure: некоторая структура, которая хранит объекты Element и 
    /// предоставляет к ним доступ. Это могут быть и простые списки, и сложные 
    /// составные структуры в виде деревьев
    /// </summary>
    class ObjectStructure_Bank
    {
        List<IElement_Account> accounts = new List<IElement_Account>();
        public void Add(IElement_Account acc)
        {
            accounts.Add(acc);
        }
        public void Remove(IElement_Account acc)
        {
            accounts.Remove(acc);
        }
        public void Accept(IVisitor visitor)
        {
            foreach (IElement_Account acc in accounts)
                acc.Accept(visitor);
        }
    }
}

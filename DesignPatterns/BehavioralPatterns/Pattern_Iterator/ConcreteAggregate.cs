using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Pattern_Iterator
{
    /// <summary>
    /// ConcreteAggregate: конкретная реализация Aggregate. Хранит элементы, которые надо будет перебирать.
    /// </summary>
    class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList _items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        // Gets item count
        public override int Count
        {
            get { return _items.Count; }
            protected set { }
        }

        // Indexer
        public override object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}

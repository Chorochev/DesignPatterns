using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Pattern_Iterator
{
    /// <summary>
    /// ConcreteIterator: конкретная реализация итератора для обхода объекта Aggregate. 
    /// Для фиксации индекса текущего перебираемого элемента использует целочисленную переменную _current.
    /// </summary>
    class ConcreteIterator : Iterator
    {
        private readonly Aggregate _aggregate;
        private int _current;

        // Constructor
        public ConcreteIterator(Aggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        // Gets first iteration item
        public override object First()
        {
            return _aggregate[0];
        }

        // Gets next iteration item
        public override object Next()
        {
            object ret = null;

            _current++;

            if (_current < _aggregate.Count)
            {
                ret = _aggregate[_current];
            }

            return ret;
        }

        // Gets current iteration item
        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        // Gets whether iterations are complete
        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }
    }
}

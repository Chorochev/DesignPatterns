Итератор (шаблон проектирования)

Шаблон проектирования - Итератор (Iterator)
Тип:	поведенческий

	Iterator — поведенческий шаблон проектирования. Представляет собой объект, позволяющий получить 
последовательный доступ к элементам объекта-агрегата без использования описаний каждого из агрегированных 
объектов.
	Например, такие элементы как дерево, связанный список, хэш-таблица и массив могут быть пролистаны 
(и модифицированы) с помощью объекта Итератор.
	Перебор элементов выполняется объектом итератора, а не самой коллекцией. Это упрощает интерфейс и реализацию 
коллекции, а также способствует более логичному разделению обязанностей.
	Особенностью полноценно реализованного итератора является то, что код, использующий итератор, может ничего 
не знать о типе итерируемого агрегата.
	Конечно же, (в С++) почти в любом агрегате можно выполнять итерации указателем void*, но при этом:
		- не ясно, что является значением «конец агрегата», для двусвязного списка это &ListHead, для массива это 
		&array[size], для односвязного списка это NULL.
		- операция Next сильно зависит от типа агрегата.

	Итераторы позволяют абстрагироваться от типа и признака окончания агрегата, используя полиморфный Next 
(часто реализованный как operator++ в С++) и полиморфный aggregate.end(), возвращающий значение «конец агрегата».
	Таким образом, появляется возможность работы с диапазонами итераторов, при отсутствии знания о типе 
итерируемого агрегата. Например (c++):

Iterator itBegin = aggregate.begin();
Iterator itEnd = aggregate.end();
func(itBegin, itEnd);
И далее:

void func(Iterator itBegin, Iterator itEnd)
{
 for( Iterator it = itBegin, it != itEnd; ++it )
 {
 }
}
------------------------------------------------------------------------------------------------------------------------------
Участники

	- Iterator: определяет интерфейс для обхода составных объектов
	- Aggregate: определяет интерфейс для создания объекта-итератора
	- ConcreteIterator: конкретная реализация итератора для обхода объекта Aggregate. Для фиксации 
	индекса текущего перебираемого элемента использует целочисленную переменную _current.
	- ConcreteAggregate: конкретная реализация Aggregate. Хранит элементы, которые надо будет перебирать.
	- Client: использует объект Aggregate и итератор для его обхода.
------------------------------------------------------------------------------------------------------------------------------
Ссылки:
	- https://metanit.com/sharp/patterns/3.5.php
	- https://ru.wikipedia.org/wiki/Итератор_(шаблон_проектирования)
------------------------------------------------------------------------------------------------------------------------------
Пример С#:

/*
sample code in C#
This structural code demonstrates the Iterator pattern which provides for a way to traverse (iterate) over a collection of items without detailing the underlying structure of the collection.
*/
Hide code 

// Iterator pattern -- Structural example

using System;
using System.Collections;
 
namespace DoFactory.GangOfFour.Iterator.Structural
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Iterator Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";
 
            // Create Iterator and provide aggregate
            ConcreteIterator i = new ConcreteIterator(a);
 
            Console.WriteLine("Iterating over collection:");
 
            object item = i.First();
            while (! i.IsDone())
            {
                Console.WriteLine(item);
                item = i.Next();
            }
 
            // Wait for user
            Console.ReadKey();
        }
    }
 
    /// <summary>
    /// The 'Aggregate' abstract class
    /// </summary>
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
        public abstract int Count { get; protected set; }
        public abstract object this[int index] { get; set; }
    }

    /// <summary>
    /// The 'ConcreteAggregate' class
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
 
    /// <summary>
    /// The 'Iterator' abstract class
    /// </summary>
    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
 
    /// <summary>
    /// The 'ConcreteIterator' class
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

Output
Iterating over collection:
Item A
Item B
Item C
Item D
------------------------------------------------------------------------------------------------------------------------------
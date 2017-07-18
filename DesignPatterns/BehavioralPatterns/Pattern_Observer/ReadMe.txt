	Наблюдатель (шаблон проектирования)

Шаблон проектирования - Наблюдатель (Observer).
Тип:	поведенческий.
	
	Назначение:	Паттерн Observer определяет зависимость "один-ко-многим" между объектами так, что при 
изменении состояния одного объекта все зависящие от него объекты уведомляются и обновляются автоматически;
	Паттерн Observer инкапсулирует главный (независимый) компонент в абстракцию Subject и изменяемые 
(зависимые) компоненты в иерархию Observer;
	Паттерн Observer определяет часть "View" в модели Model-View-Controller (MVC).

	Наблюдатель (англ. Observer) — поведенческий шаблон проектирования. Также известен как «подчинённые» 
(Dependents). Создает механизм у класса, который позволяет получать экземпляру объекта этого класса оповещения 
от других объектов об изменении их состояния, тем самым наблюдая за ними.

	Похожие шаблоны: «издатель-подписчик», «посредник», «одиночка».

	Назначение: Определяет зависимость типа «один ко многим» между объектами таким образом, что при изменении 
состояния одного объекта все зависящие от него оповещаются об этом событии.

Реализация: При реализации шаблона «наблюдатель» обычно используются следующие классы:
	- Observable — интерфейс, определяющий методы для добавления, удаления и оповещения наблюдателей;
	- Observer — интерфейс, с помощью которого наблюдатель получает оповещение;
	- ConcreteObservable — конкретный класс, который реализует интерфейс Observable;
	- ConcreteObserver — конкретный класс, который реализует интерфейс Observer.

Область применения: Шаблон «наблюдатель» применяется в тех случаях, когда система обладает следующими свойствами:
	- существует, как минимум, один объект, рассылающий сообщения;
	- имеется не менее одного получателя сообщений, причём их количество и состав могут изменяться во время работы приложения;
	- нет надобности очень сильно связывать взаимодействующие объекты, что полезно для повторного использования.

	Данный шаблон часто применяют в ситуациях, в которых отправителя сообщений не интересует, что делают получатели с 
предоставленной им информацией.

------------------------------------------------------------------------------------------------------------
Участники:
	- IObservable: представляет наблюдаемый объект. Определяет три метода: AddObserver() (для добавления 
	наблюдателя), RemoveObserver() (удаление набюдателя) и NotifyObservers() (уведомление наблюдателей).
	- ConcreteObservable: конкретная реализация интерфейса IObservable. Определяет коллекцию объектов наблюдателей.
	- IObserver: представляет наблюдателя, который подписывается на все уведомления наблюдаемого объекта. 
	Определяет метод Update(), который вызывается наблюдаемым объектом для уведомления наблюдателя.
	- ConcreteObserver: конкретная реализация интерфейса IObserver.
------------------------------------------------------------------------------------------------------------
Ссылки :
	- https://ru.wikipedia.org/wiki/Наблюдатель_(шаблон_проектирования) 
	- https://metanit.com/sharp/patterns/3.2.php 
------------------------------------------------------------------------------------------------------------
Пример

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Observer
{
    /// <summary>
    /// Observer Pattern Judith Bishop Jan 2007
    /// Updated by Kobel' Bohdan 2013
    /// 
    /// The Subject runs in a thread and changes its state
    /// independently. At each change, it notifies its Observers.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            Observer observer = new Observer(subject,"Center","\t\t");
            Observer observer2 = new Observer(subject,"Right","\t\t\t\t");
            subject.Go();

            // Wait for user
            Console.Read();
        }

    }

    class Simulator : IEnumerable 
    {
        string [] moves = {"5","3","1","6","7"};

        public IEnumerator GetEnumerator() 
        {
            foreach (string element in moves)
                yield return element;
        }
    }

    interface ISubject
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(string s);
    }

    class Subject : ISubject
    {
        public string SubjectState { get; set; }
        public List<IObserver> Observers { get; private set; }

        private Simulator simulator;

        private const int speed = 200;

        public Subject()
        {
            Observers = new List<IObserver>();
            simulator = new Simulator();
        }

        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers(string s)
        {
            foreach (var observer in Observers)
            {
                observer.Update(s);
            }
        }

        public void Go() 
        {
            new Thread(new ThreadStart(Run)).Start( );
        }

        void Run () 
        {
            foreach (string s in simulator) 
            {
                Console.WriteLine("Subject: " + s);
                SubjectState = s;
                NotifyObservers(s);
                Thread.Sleep(speed); // milliseconds
            }
        }
    }

    interface IObserver 
    {
        void Update(string state);
    }

    class Observer : IObserver
    {
        string name;

        ISubject subject;

        string state;

        string gap;

        public Observer(ISubject subject, string name, string gap)
        {
            this.subject = subject;
            this.name = name;
            this.gap = gap;
            subject.AddObserver(this);
        }

        public void Update(string subjectState)
        {
            state = subjectState;
            Console.WriteLine(gap + name + ": " + state);
        }
    }
}

------------------------------------------------------------------------------------------------------------
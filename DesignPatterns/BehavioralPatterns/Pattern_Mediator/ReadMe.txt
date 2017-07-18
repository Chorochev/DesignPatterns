	Посредник (шаблон проектирования)

Шаблон проектирования - Посредник (Mediator)
Тип:	поведенческий.

	Посредник (англ. Mediator) — поведенческий шаблон проектирования, обеспечивающий взаимодействие множества 
объектов, формируя при этом слабую связанность и избавляя объекты от необходимости явно ссылаться друг на друга.

	Проблема: Обеспечить взаимодействие множества объектов, сформировав при этом слабую связанность и избавив 
объекты от необходимости явно ссылаться друг на друга.

Решение: Создать объект, инкапсулирующий способ взаимодействия множества объектов.

Преимущества: Устраняется связанность между "Коллегами", централизуется управление.

Структура:
	- Mediator – "Посредник"
	- ConcreteMediator – "Конкретный посредник"
	- Классы Colleague – "Коллеги"

Описание:
	"Посредник" определяет интерфейс для обмена информацией с объектами "Коллеги", "Конкретный посредник" 
координирует действия объектов "Коллеги". Каждый класс "Коллеги" знает о своем объекте "Посредник", все "Коллеги" 
обмениваются информацией только с посредником, при его отсутствии им пришлось бы обмениваться информацией напрямую. 
"Коллеги" посылают запросы посреднику и получают запросы от него. "Посредник" реализует кооперативное поведение, 
пересылая каждый запрос одному или нескольким "Коллегам".

-----------------------------------------------------------------------------------------------------------------------
Участники:
	- Mediator: представляет интерфейс для взаимодействия с объектами Colleague.
	- Colleague: представляет интерфейс для взаимодействия с объектом Mediator.
	- ConcreteColleague1 и ConcreteColleague2: конкретные классы коллег, которые обмениваются друг с 
	другом через объект Mediator.
	ConcreteMediator: конкретный посредник, реализующий интерфейс типа Mediator.
-----------------------------------------------------------------------------------------------------------------------
Ссылки :
	- https://ru.wikipedia.org/wiki/Посредник_(шаблон_проектирования)
	- https://metanit.com/sharp/patterns/3.9.php
-----------------------------------------------------------------------------------------------------------------------
Пример

// Mediator pattern — Structural example
using System;
 
namespace DoFactory.GangOfFour.Mediator.Structural
{
  /// <summary>
  /// MainApp startup class for Structural
  /// Mediator Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      ConcreteMediator m = new ConcreteMediator();
 
      ConcreteColleague1 c1 = new ConcreteColleague1(m);
      ConcreteColleague2 c2 = new ConcreteColleague2(m);
 
      m.Colleague1 = c1;
      m.Colleague2 = c2;
 
      c1.Send("How are you?");
      c2.Send("Fine, thanks");
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Mediator' abstract class
  /// </summary>
  abstract class Mediator
  {
    public abstract void Send(string message, Colleague colleague);
  }
 
  /// <summary>
  /// The 'ConcreteMediator' class
  /// </summary>
  class ConcreteMediator : Mediator
  {
    public ConcreteColleague1 Colleague1 { private get; set; }
 
    public ConcreteColleague2 Colleague2 { private get; set; }
 
    public override void Send(string message, Colleague colleague)
    {
      if (colleague == Colleague1)
      {
        Colleague2.Notify(message);
      }
      else
      {
        Colleague1.Notify(message);
      }
    }
  }
 
  /// <summary>
  /// The 'Colleague' abstract class
  /// </summary>
  abstract class Colleague
  {
    protected Mediator mediator;
 
    // Constructor
    public Colleague(Mediator mediator)
    {
      this.mediator = mediator;
    }
  }
 
  /// <summary>
  /// A 'ConcreteColleague' class
  /// </summary>
  class ConcreteColleague1 : Colleague
  {
    // Constructor
    public ConcreteColleague1(Mediator mediator)
      : base(mediator)
    {
    }
 
    public void Send(string message)
    {
      mediator.Send(message, this);
    }
 
    public void Notify(string message)
    {
      Console.WriteLine("Colleague1 gets message: " + message);
    }
  }
 
  /// <summary>
  /// A 'ConcreteColleague' class
  /// </summary>
  class ConcreteColleague2 : Colleague
  {
    // Constructor
    public ConcreteColleague2(Mediator mediator)
      : base(mediator)
    {
    }
 
    public void Send(string message)
    {
      mediator.Send(message, this);
    }
 
    public void Notify(string message)
    {
      Console.WriteLine("Colleague2 gets message: " + message);
    }
  }
}

Output
Colleague2 gets message: How are you?
Colleague1 gets message: Fine, thanks

-----------------------------------------------------------------------------------------------------------------------
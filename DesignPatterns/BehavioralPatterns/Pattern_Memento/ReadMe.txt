	Хранитель (шаблон проектирования)

Шаблон проектирования - Хранитель (Memento).
Тип:	поведенческий.

	Хранитель (англ. Memento) — поведенческий шаблон проектирования, позволяющий, не нарушая инкапсуляцию, 
зафиксировать и сохранить внутреннее состояние объекта так, чтобы позднее восстановить его в это состояние.

	Существует два возможных варианта реализации данного шаблона: классический, описанный в книге Design Patterns, 
и реже встречающийся нестандартный вариант.

Применение: Шаблон Хранитель используется, когда:
	- необходимо сохранить снимок состояния объекта (или его части) для последующего восстановления.
	- прямой интерфейс получения состояния объекта раскрывает детали реализации и нарушает инкапсуляцию объекта.

Структура:
	- Originator — «Создатель».
	- Caretaker — «Опекун».
	- Memento — «Хранитель».

Описание:
	Классический вариант: Шаблон Хранитель используется двумя объектами: «Создателем» (originator) и 
«Опекуном» (caretaker). «Создатель» — это объект, у которого есть внутреннее состояние. Объект «Опекун» 
может производить некоторые действия с «Создателем», но при этом необходимо иметь возможность откатить 
изменения. Для этого «Опекун» запрашивает у «Создателя» объект «Хранителя». Затем выполняет запланированное 
действие (или последовательность действий). Для выполнения отката «Создателя» к состоянию, которое 
предшествовало изменениям, «Опекун» возвращает объект «Хранителя» его «Создателю». «Хранитель» является 
непрозрачным (то есть таким, который не может или не должен изменяться «Опекуном»).

	Нестандартный вариант: Отличие данного варианта от классического заключено в более жёстком ограничении 
на доступ «Опекуна» к внутреннему состоянию «Создателя». В классическом варианте у «Опекуна» есть потенциальная 
возможность получить доступ к внутренним данным «Создателя» через «Хранителя», изменить состояние и установить 
его обратно «Создателю». В данном варианте «Опекун» обладает возможностью лишь восстановить состояние «Хранителя», 
вызвав Restore. Кроме всего прочего, «Опекуну» не требуется владеть связью на «Хранителя», чтобы восстановить 
его состояние. Это позволяет сохранять и восстанавливать состояние сложных иерархических или сетевых структур 
(состояния объектов и всех связей между ними) путём сбора снимков всех зарегистрированных объектов системы.
-------------------------------------------------------------------------------------------------------------------
Участники:
	- Memento: хранитель, который сохраняет состояние объекта Originator и предоставляет полный доступ 
	только этому объекту Originator.
	- Originator: создает объект хранителя для сохранения своего состояния.
	- Caretaker: выполняет только функцию хранения объекта Memento, в то же время у него нет полного доступа 
	к хранителю и никаких других операций над хранителем, кроме собственно сохранения, он не производит.
-------------------------------------------------------------------------------------------------------------------
Ссылки: 
	 - https://ru.wikipedia.org/wiki/Хранитель_(шаблон_проектирования) 
	 - https://metanit.com/sharp/patterns/3.10.php
-------------------------------------------------------------------------------------------------------------------
Примеры
-------------------------------------------------------------------------------------------------------------------
Первый вариант шаблона С#

//This structural code demonstrates the Memento pattern which temporary saves and restores another object's internal state.
// Memento pattern -- Structural example

using System;
 
namespace DoFactory.GangOfFour.Memento.Structural
{
  /// <summary>
  /// MainApp startup class for Structural
  /// Memento Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      Originator o = new Originator();
      o.State = "On";
 
      // Store internal state
      Caretaker c = new Caretaker();
      c.Memento = o.CreateMemento();
 
      // Continue changing originator
      o.State = "Off";
 
      // Restore saved state
      o.SetMemento(c.Memento);
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Originator' class
  /// </summary>
  class Originator
  {
    private string _state;
 
    // Property
    public string State
    {
      get { return _state; }
      set
      {
        _state = value;
        Console.WriteLine("State = " + _state);
      }
    }
 
    // Creates memento
    public Memento CreateMemento()
    {
      return (new Memento(_state));
    }
 
    // Restores original state
    public void SetMemento(Memento memento)
    {
      Console.WriteLine("Restoring state...");
      State = memento.State;
    }
  }
 
  /// <summary>
  /// The 'Memento' class
  /// </summary>
  class Memento
  {
    private string _state;
 
    // Constructor
    public Memento(string state)
    {
      this._state = state;
    }
 
    // Gets or sets state
    public string State
    {
      get { return _state; }
    }
  }
 
  /// <summary>
  /// The 'Caretaker' class
  /// </summary>
  class Caretaker
  {
    private Memento _memento;
 
    // Gets or sets memento
    public Memento Memento
    {
      set { _memento = value; }
      get { return _memento; }
    }
  }
}

Output
State = On
State = Off
Restoring state:
State = On
-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------

using System;
namespace MementoPatte
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new Foo("Test", 15);
            foo.Print();
            Caretaker ct1 = new Caretaker();
            Caretaker ct2 = new Caretaker();
            ct1.SaveState(foo);
            foo.IntProperty += 152;
            foo.Print();
            ct2.SaveState(foo);
            ct1.RestoreState(foo);
            foo.Print();
            ct2.RestoreState(foo);
            foo.Print();
            Console.ReadKey();
        }
    }

    public interface IOriginator
    {
        object GetMemento();
        void SetMemento(object memento);
    }

    public class Foo 
        : IOriginator
    {
        public string StringProperty
        {
            get;
            private set;
        }

        public int IntProperty
        {
            get;
            set;
        }

        public Foo(string stringPropertyValue, int intPropertyValue = 0)
        {
            StringProperty = stringPropertyValue;
            IntProperty = intPropertyValue;
        }
       
        public void Print()
        {
           Console.WriteLine("=============");
           Console.WriteLine("StringProperty value: {0}",StringProperty);
           Console.WriteLine("IntProperty value: {0}",IntProperty);
           Console.WriteLine("=============");
        }
        object IOriginator.GetMemento()
        {
            return new Memento { StringProperty = this.StringProperty, IntProperty = this.IntProperty };

        }

        void IOriginator.SetMemento(object memento)
        {
            if (Object.ReferenceEquals(memento, null))
                throw new ArgumentNullException("memento");
            if (!(memento is Memento))
                throw new ArgumentException("memento");
            StringProperty = ((Memento)memento).StringProperty;
            IntProperty = ((Memento)memento).IntProperty;
        }

        class Memento
        {
            public string StringProperty
            {
                get;
                set;
            }

            public int IntProperty
            {
                get;
                set;
            }
        }
    }

    public class Caretaker
    {
        private object m_memento;
        public void SaveState(IOriginator originator)
        {
            if (originator == null)
                throw new ArgumentNullException("originator");
            m_memento = originator.GetMemento();
        }

        public void RestoreState(IOriginator originator)
        {
            if (originator == null)
                throw new ArgumentNullException("originator");
            if (m_memento == null)
                throw new InvalidOperationException("m_memento == null");
            originator.SetMemento(m_memento);
        }
    }
}
-------------------------------------------------------------------------------------------------------------------
Нестандартный вариант шаблона

using System;
using System.Collections.Generic;

public interface IOriginator
{
    IMemento GetState();
}

public interface IShape : IOriginator
{
    void Draw();
    void Scale(double scale);
    void Move(double dx, double dy);
}

public interface IMemento
{
    void RestoreState();
}

public class CircleOriginator : IShape
{
    private class CircleMemento : IMemento
    {
        private readonly double x;
        private readonly double y;
        private readonly double r;
        private readonly CircleOriginator originator;

        public CircleMemento(CircleOriginator originator)
        {
            this.originator = originator;
            x = originator.x;
            y = originator.y;
            r = originator.r;
        }

        public void RestoreState()
        {
            originator.x = x;
            originator.y = y;
            originator.r = r;
        }
    }

    double x;
    double y;
    double r;

    public CircleOriginator(double x, double y, double r)
    {
        this.x = x;
        this.y = y;
        this.r = r;
    }

    public void Draw()
    {
        Console.WriteLine("Circle with radius {0} at ({1}, {2})", r, x, y);
    }

    public void Scale(double scale)
    {
        r *= scale;
    }

    public void Move(double dx, double dy)
    {
        x += dx;
        y += dy;
    }

    public IMemento GetState()
    {
        return new CircleMemento(this);
    }
}

public class RectOriginator : IShape
{
    private class RectMemento : IMemento
    {
        private readonly double x;
        private readonly double y;
        private readonly double w;
        private readonly double h;
        private readonly RectOriginator originator;

        public RectMemento(RectOriginator originator)
        {
            this.originator = originator;
            x = originator.x;
            y = originator.y;
            w = originator.w;
            h = originator.h;
        }

        public void RestoreState()
        {
            originator.x = x;
            originator.y = y;
            originator.w = w;
            originator.h = h;
        }
    }

    double x;
    double y;
    double w;
    double h;

    public RectOriginator(double x, double y, double w, double h)
    {
        this.x = x;
        this.y = y;
        this.w = w;
        this.h = h;
    }

    public void Draw()
    {
        Console.WriteLine("Rectangle {0}x{1} at ({2}, {3})", w, h, x, y);
    }

    public void Scale(double scale)
    {
        w *= scale;
        h *= scale;
    }

    public void Move(double dx, double dy)
    {
        x += dx;
        y += dy;
    }

    public IMemento GetState()
    {
        return new RectMemento(this);
    }
}

public class Caretaker
{
    public static void Draw(IEnumerable<IShape> shapes)
    {
        foreach (IShape shape in shapes)
        {
            shape.Draw();
        }
    }

    public static void MoveAndScale(IEnumerable<IShape> shapes)
    {
        foreach (IShape shape in shapes)
        {
            shape.Scale(10);
            shape.Move(3, 2);
        }
    }

    public static IEnumerable<IMemento> SaveStates(IEnumerable<IShape> shapes)
    {
        LinkedList<IMemento> states = new LinkedList<IMemento>();
        foreach (IShape shape in shapes)
        {
            states.AddLast(shape.GetState());
        }
        return states;
    }

    public static void RestoreStates(IEnumerable<IMemento> states)
    {
        foreach (IMemento state in states)
        {
            state.RestoreState();
        }
    }

    public static void Main()
    {
        IShape[] shapes = { new RectOriginator(10, 20, 3, 5), new CircleOriginator(5, 2, 10) };

        //Выводит:
        // Rectangle 3x5 at (10, 20)
        // Circle with radius 10 at (5, 2)
        Draw(shapes);

        //Сохраняем состояния фигур
        IEnumerable<IMemento> states = SaveStates(shapes);

        //Изменяем положение фигур
        MoveAndScale(shapes);

        //Выводит:
        // Rectangle 30x50 at (13, 22)
        // Circle with radius 100 at (8, 4)
        Draw(shapes);

        //Восстановление старого положения фигур
        RestoreStates(states);

        //Выводит:
        // Rectangle 3x5 at (10, 20)
        // Circle with radius 10 at (5, 2)
        Draw(shapes);
    }
}

-------------------------------------------------------------------------------------------------------------------
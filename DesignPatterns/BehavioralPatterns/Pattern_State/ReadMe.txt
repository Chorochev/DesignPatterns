	Состояние (шаблон проектирования)

Шаблон проектирования - Состояние (State)
Тип:	поведенческий.

	Состояние (англ. State) — поведенческий шаблон проектирования. Используется в тех случаях, 
когда во время выполнения программы объект должен менять своё поведение в зависимости от своего состояния.

Паттерн состоит из 3 блоков:
	 - Widget — класс, объекты которого должны менять своё поведение в зависимости от состояния.
	 - IState — интерфейс, который должен реализовать каждое из конкретных состояний. Через этот интерфейс 
	 объект Widget взаимодействует с состоянием, делегируя ему вызовы методов. Интерфейс должен содержать 
	 средства для обратной связи с объектом, поведение которого нужно изменить. Для этого используется 
	 событие (паттерн Publisher — Subscriber). Это необходимо для того, чтобы в процессе выполнения программы 
	 заменять объект состояния при появлении событий. Возможны случаи, когда сам Widget периодически 
	 опрашивает объект состояние на наличие перехода.
	 - StateA … StateZ — классы конкретных состояний. Должны содержать информацию о том, при каких условиях 
	 и в какие состояния может переходить объект из текущего состояния. Например, из StateA объект может 
	 переходить в состояние StateB и StateC, а из StateB — обратно в StateA и так далее. Объект одного из них 
	 должен содержать Widget при создании.

---------------------------------------------------------------------------------------------------------------------
Участники паттерна:
	- State: определяет интерфейс состояния.
	- Классы StateA и StateB - конкретные реализации состояний.
	- Context: представляет объект, поведение которого должно динамически изменяться в соответствии с состоянием. 
	Выполнение же конкретных действий делегируется объекту состояния.
---------------------------------------------------------------------------------------------------------------------
	Ссылки: 
		- https://ru.wikipedia.org/wiki/Состояние_(шаблон_проектирования)
		- https://metanit.com/sharp/patterns/3.6.php 
---------------------------------------------------------------------------------------------------------------------
Пример
using System;

namespace Digital_Patterns.Behavioral.State
{
    public interface IAutomatState
    {
        String GotApplication();
        String CheckApplication();
        String RentApartment();
        String DispenseKeys();
    }
    public interface IAutomat
    {
        void GotApplication();
        void CheckApplication();
        void RentApartment();

        void SetState(IAutomatState s);
        IAutomatState GetWaitingState();
        IAutomatState GetGotApplicationState();
        IAutomatState GetApartmentRentedState();
        IAutomatState GetFullyRentedState();

        Int32 Count { get; set; }
    }

    public class Automat : IAutomat
    {
        private IAutomatState _waitingState;
        private IAutomatState _gotApplicationState;
        private IAutomatState _apartmentRentedState;
        private IAutomatState _fullyRentedState;
        private IAutomatState _state;
        private Int32 _count;

        public Automat(Int32 n)
        {
            _count = n;
            _waitingState = new WaitingState(this);
            _gotApplicationState = new GotApplicationState(this);
            _apartmentRentedState = new ApartmentRentedState(this);
            _fullyRentedState = new FullyRentedState(this);
            _state = _waitingState;
        }

        public void GotApplication()
        {
            Console.WriteLine(_state.GotApplication());
        }

        public void CheckApplication()
        {
            Console.WriteLine(_state.CheckApplication());
        }

        public void RentApartment()
        {
            Console.WriteLine(_state.RentApartment());
            Console.WriteLine(_state.DispenseKeys());
        }

        public void SetState(IAutomatState s) { _state = s; }

        public IAutomatState GetWaitingState() { return _waitingState; }

        public IAutomatState GetGotApplicationState() { return _gotApplicationState; }

        public IAutomatState GetApartmentRentedState() { return _apartmentRentedState; }

        public IAutomatState GetFullyRentedState() { return _fullyRentedState; }

        public int Count 
        { 
            get { return _count; }
            set { _count = value; }
        }
    }

    public class WaitingState : IAutomatState
    {
        private Automat _automat;

        public WaitingState(Automat automat)
        {
            _automat = automat;
        }

        public String GotApplication()
        {
            _automat.SetState(_automat.GetGotApplicationState());
            return "Thanks for the application.";
        }

        public String CheckApplication() { return "You have to submit an application."; }

        public String RentApartment() { return "You have to submit an application."; }

        public String DispenseKeys() { return "You have to submit an application."; }
    }

    public class GotApplicationState : IAutomatState
    {
        private Automat _automat;
        private readonly Random _random;

        public GotApplicationState(Automat automat)
        {
            _automat = automat;
            _random = new Random(System.DateTime.Now.Millisecond);
        }

        public String GotApplication() { return "We already got your application."; }

        public String CheckApplication()
        {
            var yesNo = _random.Next() % 10;

            if (yesNo > 4 && _automat.Count > 0)
            {
                _automat.SetState(_automat.GetApartmentRentedState());
                return "Congratulations, you were approved.";
            }
            else
            {
                _automat.SetState(_automat.GetWaitingState());
                return "Sorry, you were not approved.";
            }
        }

        public String RentApartment() { return "You must have your application checked."; }

        public String DispenseKeys() { return "You must have your application checked."; }
    }

    public class ApartmentRentedState : IAutomatState
    {
        private Automat _automat;

        public ApartmentRentedState(Automat automat)
        {
            _automat = automat;
        }

        public String GotApplication() { return "Hang on, we'ra renting you an apartmeny."; }

        public String CheckApplication() { return "Hang on, we'ra renting you an apartmeny."; }

        public String RentApartment()
        {
            _automat.Count = _automat.Count - 1;
            return "Renting you an apartment....";
        }

        public String DispenseKeys()
        {
            if(_automat.Count <= 0)
                _automat.SetState(_automat.GetFullyRentedState());
            else
                _automat.SetState(_automat.GetWaitingState());
            return "Here are your keys!";
        }
    }

    public class FullyRentedState : IAutomatState
    {
        private Automat _automat;

        public FullyRentedState(Automat automat)
        {
            _automat = automat;
        }

        public String GotApplication() { return "Sorry, we're fully rented."; }

        public String CheckApplication() { return "Sorry, we're fully rented."; }

        public String RentApartment() { return "Sorry, we're fully rented."; }

        public String DispenseKeys() { return "Sorry, we're fully rented."; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var automat = new Automat(9);

            automat.GotApplication();
            automat.CheckApplication();
            automat.RentApartment();
        }
    }
}
---------------------------------------------------------------------------------------------------------------------

Тот же пример, без применения шаблона

Исходный текст на языке C#[скрыть]
using System;

namespace Digital_Patterns.Behavioral.State
{
    public enum State
    {
        FULLY_RENTED = 0,
        WAITING = 1,
        GOT_APPLICATION = 2,
        APARTMENT_RENTED = 3,
    }

    public class RentalMethods
    {
        private readonly Random _random;
        private Int32 _numberApartments;
        private State _state = State.WAITING;

        public RentalMethods(Int32 n)
        {
            _numberApartments = n;
            _random = new Random(System.DateTime.Now.Millisecond);
        }

        public void GetApplication()
        {
            switch (_state)
            {
                case State.FULLY_RENTED:
                    Console.WriteLine("Sorry, we're fully rented.");
                    break;
                case State.WAITING:
                    _state = State.GOT_APPLICATION;
                    Console.WriteLine("Thanks for the application.");
                    break;
                case State.GOT_APPLICATION:
                    Console.WriteLine("We already got your application.");
                    break;
                case State.APARTMENT_RENTED:
                    Console.WriteLine("Hang on, we'ra renting you an apartment.");
                    break;
            }
        }

        public void CheckApplication()
        {
            var yesNo = _random.Next()%10;

            switch (_state)
            {
                case State.FULLY_RENTED:
                    Console.WriteLine("Sorry, we're fully rented.");
                    break;
                case State.WAITING:
                    Console.WriteLine("You have to submit an application.");
                    break;
                case State.GOT_APPLICATION:
                    if (yesNo > 4 && _numberApartments > 0)
                    {
                        Console.WriteLine("Congratulations, you were approved.");
                        _state = State.APARTMENT_RENTED;
                        RentApartment();
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you were not approved.");
                        _state = State.WAITING;
                    }
                    break;
                case State.APARTMENT_RENTED:
                    Console.WriteLine("Hang on, we'ra renting you an apartment.");
                    break;
            }
        }

        public void RentApartment()
        {
            switch (_state)
            {
                case State.FULLY_RENTED:
                    Console.WriteLine("Sorry, we're fully rented.");
                    break;
                case State.WAITING:
                    Console.WriteLine("You have to submit an application.");
                    break;
                case State.GOT_APPLICATION:
                    Console.WriteLine("You must have your application checked.");
                    break;
                case State.APARTMENT_RENTED:
                    Console.WriteLine("Renting you an apartment....");
                    _numberApartments--;
                    DispenseKeys();
                    break;
            }
            
        }

        public void DispenseKeys()
        {
            switch (_state)
            {
                case State.FULLY_RENTED:
                    Console.WriteLine("Sorry, we're fully rented.");
                    break;
                case State.WAITING:
                    Console.WriteLine("You have to submit an application.");
                    break;
                case State.GOT_APPLICATION:
                    Console.WriteLine("You must have your application checked.");
                    break;
                case State.APARTMENT_RENTED:
                    Console.WriteLine("Here are your keys!");
                    _state = State.WAITING;
                    break;
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var rentalMethods = new RentalMethods(9);

            rentalMethods.GetApplication();

            rentalMethods.CheckApplication();
            rentalMethods.RentApartment();
            rentalMethods.DispenseKeys();
        }
    }
}
---------------------------------------------------------------------------------------------------------------------
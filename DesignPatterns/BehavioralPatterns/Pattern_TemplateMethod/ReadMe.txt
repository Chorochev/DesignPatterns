	Шаблонный метод (шаблон проектирования)

	Шаблон проектирования - Шаблонный метод (Template method)
	Тип:	поведенческий.

	Шаблонный метод (англ. Template method) — поведенческий шаблон проектирования, определяющий основу алгоритма и 
позволяющий наследникам переопределять некоторые шаги алгоритма, не изменяя его структуру в целом.

	Применимость:
	- Однократное использование инвариантной части алгоритма, с оставлением изменяющейся части на усмотрение наследникам.
	- Локализация и вычленение общего для нескольких классов кода для избегания дублирования.
	- Разрешение расширения кода наследниками только в определенных местах.

	Участники:
	- Abstract class (абстрактный класс) - определяет абстрактные операции, замещаемые в наследниках для реализации шагов 
	алгоритма; реализует шаблонный метод, определяющий скелет алгоритма. Шаблонный метод вызывает замещаемые и другие, 
	определенные в Abstract class, операции.
	- Concrete class (конкретный класс) - реализует замещаемые операции необходимым для данной реализации способом.
	- Concrete class предполагает, что инвариантные шаги алгоритма будут выполнены в AbstractClass.

-----------------------------------------------------------------------------------------------------------------------------
Ссылки:
	- https://ru.wikipedia.org/wiki/Шаблонный_метод_(шаблон_проектирования) 
	- https://metanit.com/sharp/patterns/3.4.php
-----------------------------------------------------------------------------------------------------------------------------	
Пример

/**
 * An abstract class that is common to several games in
 * which players play against the others, but only one is
 * playing at a given time.
 */

namespace Design_Patterns
{
    class TemplateMethodPattern
    {
        internal abstract class GameObject
        {
            protected int PlayersCount;

            abstract protected bool EndOfGame();

            abstract protected void InitializeGame();

            abstract protected void MakePlay(int player);

            abstract protected void PrintWinner();

            /* A template method : */
            public void PlayOneGame(int playersCount)
            {
                PlayersCount = playersCount;
                InitializeGame();
                
                var j = 0;

                while (!EndOfGame())
                {
                    MakePlay(j);
                    j = (j + 1) % playersCount;
                }

                PrintWinner();
            }
        }

        //Now we can extend this class in order to implement actual games:

        public class Monopoly : GameObject
        {
            /* Implementation of necessary concrete methods */

            protected override void InitializeGame()
            {
                // Initialize money
            }

            protected override void MakePlay(int player)
            {
                // Process one turn of player
            }

            protected override bool EndOfGame()
            {
                return true;
            }

            protected override void PrintWinner()
            {
                // Display who won
            }

            /* Specific declarations for the Monopoly game. */

            // ...

        }

        public class Chess : GameObject
        {

            /* Implementation of necessary concrete methods */

            protected override void InitializeGame()
            {
                // Put the pieces on the board
            }

            protected override void MakePlay(int player)
            {
                // Process a turn for the player
            }

            protected override bool EndOfGame()
            {
                return true;
                // Return true if in Checkmate or Stalemate has been reached
            }

            protected override void PrintWinner()
            {
                // Display the winning player
            }

            /* Specific declarations for the chess game. */

            // ...

        }

        public static void Test()
        {
            GameObject game = new Monopoly();

            game.PlayOneGame(2);
        }
    }
}
-----------------------------------------------------------------------------------------------------------------------------

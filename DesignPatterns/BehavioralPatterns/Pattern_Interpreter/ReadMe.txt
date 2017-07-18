Интерпретатор (шаблон проектирования)

Шаблон проектирования - Интерпретатор (Interpreter)

Тип:	поведенческий.
Назначение:	решает часто встречающуюся, подверженную изменениям задачу.

	Интерпретатор (англ. Interpreter) — поведенческий шаблон проектирования, решающий часто встречающуюся, но 
подверженную изменениям, задачу. Также известен как Little (Small) Language.

	Проблема: Имеется часто встречающаяся, подверженная изменениям задача.
	Решение: Создать интерпретатор, который решает данную задачу.

	Преимущества: Грамматику становится легко расширять и изменять, реализации классов, описывающих узлы абстрактного 
синтаксического дерева похожи (легко кодируются). Можно легко изменять способ вычисления выражений.
	Недостатки: Сопровождение грамматики с большим числом правил затруднительно.

	Пример: Задача поиска строк по образцу может быть решена посредством создания интерпретатора, определяющего 
грамматику языка. "Клиент" строит предложение в виде абстрактного синтаксического дерева, в узлах которого находятся 
объекты классов "НетерминальноеВыражение" и "ТерминальноеВыражение" (рекурсивное), затем "Клиент" инициализирует 
контекст и вызывает операцию Разобрать(Контекст). На каждом узле типа "НетерминальноеВыражение" определяется операция 
"Разобрать" для каждого подвыражения. Для класса "ТерминальноеВыражение" операция Разобрать определяет базу рекурсии. 
"АбстрактноеВыражение" определяет абстрактную операцию Разобрать, общую для всех узлов в абстрактном синтаксическом 
дереве. "Контекст" содержит информацию, глобальную по отношению к интерпретатору.

---------------------------------------------------------------------------------------------------------------------------
Участники: 
	- AbstractExpression: определяет интерфейс выражения, объявляет метод Interpret().
	- TerminalExpression: терминальное выражение, реализует метод Interpret() для терминальных символов грамматики. 
	Для каждого символа грамматики создается свой объект TerminalExpression.
	- NonterminalExpression: нетерминальное выражение, представляет правило грамматики. Для каждого отдельного правила 
	грамматики создается свой объект NonterminalExpression.
	- Context: содержит общую для интерпретатора информацию. Может использоваться объектами терминальных и нетерминальных 
	выражений для сохранения состояния операций и последующего доступа к сохраненному состоянию.
	- Client: строит предложения языка с данной грамматикой в виде абстрактного синтаксического дерева, узлами которого 
	являются объекты TerminalExpression и NonterminalExpression.
---------------------------------------------------------------------------------------------------------------------------
Ссылки:
	- https://ru.wikipedia.org/wiki/Интерпретатор_(шаблон_проектирования) 
	- https://metanit.com/sharp/patterns/3.8.php 
---------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections;
 
namespace DoFactory.GangOfFour.Interpreter.Structural
{
  /// <summary>
  /// MainApp startup class for Structural
  /// Interpreter Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      Context context = new Context();
 
      // Usually a tree
      ArrayList list = new ArrayList();
 
      // Populate 'abstract syntax tree'
      list.Add(new TerminalExpression());
      list.Add(new NonterminalExpression());
      list.Add(new TerminalExpression());
      list.Add(new TerminalExpression());
 
      // Interpret
      foreach (AbstractExpression exp in list)
      {
        exp.Interpret(context);
      }
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Context' class
  /// </summary>
  class Context
  {
  }
 
  /// <summary>
  /// The 'AbstractExpression' abstract class
  /// </summary>
  abstract class AbstractExpression
  {
    public abstract void Interpret(Context context);
  }
 
  /// <summary>
  /// The 'TerminalExpression' class
  /// </summary>
  class TerminalExpression : AbstractExpression
  {
    public override void Interpret(Context context)
    {
      Console.WriteLine("Called Terminal.Interpret()");
    }
  }
 
  /// <summary>
  /// The 'NonterminalExpression' class
  /// </summary>
  class NonterminalExpression : AbstractExpression
  {
    public override void Interpret(Context context)
    {
      Console.WriteLine("Called Nonterminal.Interpret()");
    }
  }
}

/* Output
Called Terminal.Interpret()
Called Nonterminal.Interpret()
Called Terminal.Interpret()
Called Terminal.Interpret()
*/


---------------------------------------------------------------------------------------------------------------------------
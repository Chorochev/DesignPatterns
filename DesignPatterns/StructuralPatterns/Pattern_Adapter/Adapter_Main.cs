using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Adapter
{
    public static class Adapter_Main
    {
        public static void Go()
        {
            // Иницилизируем классы которые нужно адаптировать
            AdapterSquare sqare = new AdapterSquare(10, 2);
            AdapterCircle circle = new AdapterCircle(5);
            // Инициализируем клиента
            ClientFigure client = new ClientFigure();
            // Формируем фигуру "Квадрат"
            client.Name = "Квадрат";
            client.SetFigure(sqare);
            client.SetArea();
            client.Info();

            System.Console.WriteLine("**********************************************");
            // Формируем фигуру "Круг"
            client.Name = "Круг";
            client.SetFigure(circle);
            client.SetArea();
            client.Info();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Pattern_Proxy
{
    /// <summary>
    /// Subject - субъект
    /// </summary>
    /// <remarks>
    /// <li>
    /// <lu>определяет общий для <see cref="Math_RealSubject"/> и <see cref="Proxy"/> интерфейс, так что класс
    /// <see cref="Proxy"/> можно использовать везде, где ожидается <see cref="Math_RealSubject"/></lu>
    /// </li>
    /// </remarks>
    public interface IMath_Subject
    {
        double Add(double x, double y);
        double Sub(double x, double y);
        double Mul(double x, double y);
        double Div(double x, double y);
    }
}

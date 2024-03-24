using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Clases
{
    public class Polimorfismo
    {
        public virtual double Calcular(double num1, double num2)
        {
            return 0; // Operación base, no hace nada
        }
    }

    public class Suma : Polimorfismo
    {
        public override double Calcular(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    public class Resta : Polimorfismo
    {
        public override double Calcular(double num1, double num2)
        {
            return num1 - num2;
        }
    }

    public class Multiplicacion : Polimorfismo
    {
        public override double Calcular(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}

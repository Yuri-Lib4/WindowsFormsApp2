using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Clases
{
    public class Herencia
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int CantidadVentas { get; set; }
        public int Faltas { get; set; }
        public int Permisos { get; set; }

        public Herencia(string nombre, string email, int ventas, int faltas, int permisos)
        {
            Nombre = nombre;
            Email = email;
            CantidadVentas = ventas;
            Faltas = faltas;
            Permisos = permisos;
        }
        public class CalculadoraSalario : Herencia
        {
            public CalculadoraSalario(string nombre, string email, int ventas, int faltas, int permisos)
        : base(nombre, email, ventas, faltas, permisos)
            {
            }

            public (double salario, double descuentoFaltas, double descuentoPermisos) CalcularSalarioConDescuentos()
            {
                double salarioBase = 1000; // Salario base quincenal
                double salarioFinal = salarioBase; // Inicializamos con el salario base
                double descuentoFaltas = Faltas * (salarioBase * 0.3);
                double descuentoPermisos = Permisos * (salarioBase * 0.15);

                // Aplicar descuentos por faltas y permisos
                salarioFinal -= descuentoFaltas;
                salarioFinal -= descuentoPermisos;

                // Calcular bonificación por ventas
                if (CantidadVentas > 60)
                {
                    salarioFinal += (CantidadVentas - 60) * 14;
                }

                return (salarioFinal, descuentoFaltas, descuentoPermisos);
            }
        }

    }
}

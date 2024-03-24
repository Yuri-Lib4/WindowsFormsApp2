using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.Clases.Herencia;

namespace WindowsFormsApp2.Formularios
{
    public partial class fmrArticulos : Form
    {
        public fmrArticulos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string email = txtEmail.Text;
            int ventas = int.Parse(txtVentas.Text);
            int faltas = int.Parse(txtFaltas.Text);
            int permisos = int.Parse(txtPermisos.Text);

            // Crear una instancia de CalculadoraSalario
            CalculadoraSalario calculadora = new CalculadoraSalario(nombre, email, ventas, faltas, permisos);

            // Calcular el salario
            var resultados = calculadora.CalcularSalarioConDescuentos();

            // Mostrar el salario calculado y los descuentos en los TextBoxes
            txtSalario.Text = resultados.salario.ToString();
            txtDescuentoFaltas.Text = resultados.descuentoFaltas.ToString();
            txtDescuentoPermisos.Text = resultados.descuentoPermisos.ToString();
        }
    }
}

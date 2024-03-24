using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Clases;

namespace WindowsFormsApp2.Formularios
{
    public partial class fmrClientes : Form
    {
        public fmrClientes()
        {
            InitializeComponent();
            cmbOperacion.Items.Add("Suma");
            cmbOperacion.Items.Add("Resta");
            cmbOperacion.Items.Add("Multiplicación");
            cmbOperacion.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);

           
            Polimorfismo operacion;
            switch (cmbOperacion.SelectedItem.ToString())
            {
                case "Suma":
                    operacion = new Suma();
                    break;
                case "Resta":
                    operacion = new Resta();
                    break;
                case "Multiplicación":
                    operacion = new Multiplicacion();
                    break;
                default:
                    operacion = new Polimorfismo(); // Por defecto, no hace nada
                    break;
            }

           
            double resultado = operacion.Calcular(num1, num2);
            txtResultado.Text = resultado.ToString();
        }
    }
}

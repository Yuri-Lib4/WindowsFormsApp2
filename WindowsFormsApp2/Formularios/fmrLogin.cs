using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Formularios
{
    public partial class fmrLogin : Form

    {
        private Dictionary<string, string> usuarios = new Dictionary<string, string>();
        public fmrLogin()
        {
            InitializeComponent();
            // Agregamos usuarios 
            usuarios.Add("Yuri", "Carrasco");
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;

            // Verificar si el usuario existe en el diccionario 
            if (usuarios.ContainsKey(usuario) && usuarios[usuario] == contrasena)
            {
                
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                Form1 formPrincipal = new Form1();
                formPrincipal.Show();
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

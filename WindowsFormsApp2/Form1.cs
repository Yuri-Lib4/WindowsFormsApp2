using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Formularios;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        fmrArticulos fa;
        fmrClientes fc;
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lblUsuario.Text = fmrLogin.claseCompartida.usuario;
        }


        void formulariosArticulos()
        {
            if (fa == null)
            {
                fa = new fmrArticulos();
                fa.FormClosed += new FormClosedEventHandler(fa_cierre);
                fa.MdiParent = this;
                fa.Show();
            }
        }

        void formulariosClientes()
        {
            if (fa == null)
            {
                fc = new fmrClientes();
                fc.FormClosed += new FormClosedEventHandler(fc_cierre);
                fc.MdiParent = this;
                fc.Show();
            }
        }

        void fa_cierre(object senser, EventArgs e)
        {
            fa = null;
        }

        void fc_cierre(object senser, EventArgs e)
        {
            fc = null;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulariosClientes();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            formulariosArticulos();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulariosArticulos();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            formulariosClientes();
        }
    }
}

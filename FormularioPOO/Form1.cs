using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clasess;

namespace FormularioPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Vendedor yaned = new Vendedor();
            yaned.Apellidos = txtapellido.Text;
            yaned.Nombre = txtnombre.Text;
            yaned.Documento = txtdocumento.Text;
            yaned.Tipo = cbxtipo.Text;
            yaned.Tipocontrato = cbxcontrato.Text;

            yaned.calcularsueldo(1000000);

            dataGridView1.Rows.Insert(0, yaned.Tipo, yaned.Nombre, yaned.Apellidos, yaned.Documento, yaned.Tipocontrato);

        }
    }
}

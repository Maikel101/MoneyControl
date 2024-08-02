using Money.Clases;
using Money.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money
{
    public partial class FTipoIngreso : Form
    {
        public FTipoIngreso()
        {
            InitializeComponent();
        }

        bool Editar;
        int IdTipoIngreso;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        private void ListarGrid()
        {
            dgvDatos.DataSource = TipoIngreso.Listar();
            DBDatos.OcultarIds(dgvDatos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validacion()) return;

            if (!Guardar()) return;

            Finalizar();
        }

        private void Finalizar()
        {
            ListarGrid();
            Limpiar();
        }

        private void Limpiar()
        {
            txtIngreso.Text = "";
            Editar = false;
        }

        private bool Guardar()
        {
            TipoIngreso tipoIngreso = new TipoIngreso
            {
                Denominacion = txtIngreso.Text,
                IdTipoIngreso = IdTipoIngreso
            };

            return TipoIngreso.Guardar(tipoIngreso, Editar);
        }

        private bool Validacion()
        {
            if (string.IsNullOrWhiteSpace(txtIngreso.Text))
            {
                MessageBox.Show("Ingresar denominación.");
                return false;
            }
            return true;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdTipoIngreso = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IDTipoIngreso"].Value);
            txtIngreso.Text = dgvDatos.CurrentRow.Cells["Denominacion"].Value.ToString();
            Editar = true;
        }
    }
}

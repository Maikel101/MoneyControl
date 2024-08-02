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

namespace Money.Formularios
{
    public partial class FTipoGasto : Form
    {
        public FTipoGasto()
        {
            InitializeComponent();
        }

        bool Editar;
        int IdTipoGasto;

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void FTipoGasto_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        private void ListarGrid()
        {
            dgvDatos.DataSource = TipoGasto.Listar();
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
            txtGasto.Text = "";
            Editar = false;
        }

        private bool Guardar()
        {
            TipoGasto tipoGasto = new TipoGasto
            {
                Denominacion = txtGasto.Text,
                IdTipoGasto = IdTipoGasto
            };

            return TipoGasto.Guardar(tipoGasto, Editar);
        }

        private bool Validacion()
        {
            if (string.IsNullOrWhiteSpace(txtGasto.Text))
            {
                MessageBox.Show("Ingresar denominación.");
                return false;
            }
            return true;
        }

        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            IdTipoGasto = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IDTipoGasto"].Value);
            txtGasto.Text = dgvDatos.CurrentRow.Cells["Denominacion"].Value.ToString();
            Editar = true;
        }

        private void txtIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

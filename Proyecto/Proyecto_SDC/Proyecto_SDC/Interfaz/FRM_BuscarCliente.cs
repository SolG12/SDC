using Proyecto_SDC.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_SDC.Interfaz
{
    public partial class FRM_BuscarCliente : Form
    {
        public string Busqueda;
        public int Seleccion { get; set; }

        public FRM_BuscarCliente()
        {
            InitializeComponent();
        }

        private void FRM_BuscarCliente_Load(object sender, EventArgs e)
        {

        }

        private void FRM_BuscarCliente_Activated(object sender, EventArgs e)
        {
            ControlCliente mControlCliente = new ControlCliente();
            try
            {
                dgv_clientes.DataSource = mControlCliente.ConsultarCliente();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ControlCliente mControlCliente = new ControlCliente();
            try
            {
                dgv_clientes.DataSource = mControlCliente.BuscarCliente(txtBusqueada.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void dgv_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccion = (int)dgv_clientes.SelectedRows[0].Cells[0].Value;
        }
    }
}

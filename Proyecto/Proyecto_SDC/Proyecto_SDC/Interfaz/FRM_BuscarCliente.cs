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
            FRM_Principal mFRM_Principal = new FRM_Principal();
            this.Hide();
            mFRM_Principal.Show();

        }
    }
}

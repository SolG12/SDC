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
    public partial class FRM_Principal : Form
    {
        public FRM_Principal()
        {
            InitializeComponent();
        }

        private void BtnRCliente_Click(object sender, EventArgs e)
        {
            FRM_RegitrarCliente mFRM_RegitrarCliente = new FRM_RegitrarCliente();
            this.Hide();
            mFRM_RegitrarCliente.Show();

        }

        private void BtnREquipo_Click(object sender, EventArgs e)
        {
            FRM_RegistrarEquipo mFRM_RegistrarEquipo = new FRM_RegistrarEquipo();
            this.Hide();
            mFRM_RegistrarEquipo.Show();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            FRM_Consulta mFRM_Consulta = new FRM_Consulta();
            this.Hide();
            mFRM_Consulta.Show();
        }

        private void BtnCerra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

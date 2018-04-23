using Proyecto_SDC.Datos;
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
    public partial class FRM_Consulta : Form
    {
        public FRM_Consulta()
        {
            InitializeComponent();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            FRM_Principal mFRM_Principal = new FRM_Principal();
            this.Hide();
            mFRM_Principal.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ControlEquipo mControlEquipo = new ControlEquipo();
            try
            {
                DgvConsulta.DataSource = mControlEquipo.ConsultarEquipo(txtNoOrden.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void FRM_Consulta_Load(object sender, EventArgs e)
        {

        }

        private void FRM_Consulta_Activated(object sender, EventArgs e)
        {
            ControlEquipo mControlEquipo = new ControlEquipo();
            try
            {
                DgvConsulta.DataSource = mControlEquipo.ConsultarEquipos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnGR_Click(object sender, EventArgs e)
        {

        }

        private void BtnAequipo_Click(object sender, EventArgs e)
        {

        }

        private void DgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Consulta mActualizar = new FRM_Consulta();
            Equipo mEquipo = new Equipo();

            

        }
    }
}

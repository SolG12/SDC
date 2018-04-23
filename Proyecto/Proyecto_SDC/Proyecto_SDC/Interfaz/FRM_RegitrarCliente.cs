using Proyecto_SDC.Datos;
using Proyecto_SDC.Interfaz;
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

namespace Proyecto_SDC
{
    public partial class FRM_RegitrarCliente : Form
    {
        public FRM_RegitrarCliente()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FRM_Principal mFRM_Principal = new FRM_Principal();
            this.Hide();
            mFRM_Principal.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "")
            {
                try
                {
                    Cliente mCliente = new Cliente();
                    mCliente.Nombre = txtNombre.Text;
                    mCliente.Direccion = txtDireccion.Text;
                    mCliente.Telefono = txtTelefono.Text;

                    ControlCliente mcontrolCliente = new ControlCliente();
                    mcontrolCliente.AgregarCliente(mCliente);
                    MessageBox.Show("Cliente Guardado");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al Actualizar");

                }

            }
            else
            {
                MessageBox.Show("¡Favor de llenar campos vacíos!");
            }
        }

        private void BtnREquipo_Click(object sender, EventArgs e)
        {
            FRM_RegistrarEquipo mFRM_RegistrarEquipo = new FRM_RegistrarEquipo();
            this.Hide();
            mFRM_RegistrarEquipo.Show();

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



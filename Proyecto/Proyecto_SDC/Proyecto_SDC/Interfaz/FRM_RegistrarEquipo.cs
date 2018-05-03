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
    public partial class FRM_RegistrarEquipo : Form
    {
        public FRM_RegistrarEquipo()
        {
            InitializeComponent();
        }

        private void cmbFuncionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FRM_Principal mFRM_Principal = new FRM_Principal();
            this.Hide();
            mFRM_Principal.Show();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FRM_RegitrarCliente mFRM_RegitrarCliente = new FRM_RegitrarCliente();
            this.Hide();
            mFRM_RegitrarCliente.Show();


        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text != "" && txtModelo.Text != "" && txtTipo.Text != "" && cmbFuncionalidad.Text != "")
            {
                try
                {
                    Equipo mEquipo = new Equipo();
                    mEquipo.id_cliente = int.Parse(txtCliente.Text);
                    mEquipo.Marca = txtMarca.Text;
                    mEquipo.Modelo = txtModelo.Text;
                    mEquipo.Tipo = txtTipo.Text;
                    mEquipo.Funcionalidad = cmbFuncionalidad.SelectedItem.ToString();


                    ControlEquipo mControlEquipo = new ControlEquipo();
                    mControlEquipo.AgregarEquipo(mEquipo);
                    MessageBox.Show("Equipo Guardado");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al Actualizar: " + e);

                }

            }
            else
            {
                MessageBox.Show("¡Favor de llenar campos vacíos!");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FRM_BuscarCliente mFRM_BuscarCliente = new FRM_BuscarCliente();
            if (mFRM_BuscarCliente.ShowDialog() == DialogResult.OK)
            {
                txtCliente.Text = mFRM_BuscarCliente.Seleccion.ToString();
            }
           
        }
    }
}


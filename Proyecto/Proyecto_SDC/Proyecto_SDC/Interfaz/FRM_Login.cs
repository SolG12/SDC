using Proyecto_SDC.BD;
using Proyecto_SDC.Interfaz;
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
    public partial class FRM_Login : Form
    {
        int Contador = 0;

        Conexion mConexion;

        public FRM_Login()
        {
            InitializeComponent();
            mConexion = new Conexion();
            mConexion.Conectar("MySQL ODBC 5.2w Driver", "localhost",
                "mantenimientobd", "root", "");
        }



        private void BtnIniciar_Click_1(object sender, EventArgs e)
        {
            if ((txtUser.Text != "") && (txtPass.Text != ""))
            {
                if ((txtUser.Text == "admin") && (txtPass.Text == "1234"))
                {
                    FRM_Principal mFRM_Principal = new FRM_Principal();
                    mFRM_Principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrecto");
                    Contador++;
                    if (Contador == 3)
                    {
                        MessageBox.Show("¡Número de intentos excedido!");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("¡Favor de llenar campos vacíos!");

            }
        }
    }
}
    


  

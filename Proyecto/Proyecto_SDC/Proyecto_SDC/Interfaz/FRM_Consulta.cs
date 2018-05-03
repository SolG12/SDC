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
using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;
using System.IO;
using System.Diagnostics;

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
            try
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Reporte1.pdf", FileMode.Create));
                doc.Open();
                PdfPTable table = new PdfPTable(DgvConsulta.Columns.Count - 1);
                table.AddCell(new Phrase("No Orden"));
                table.AddCell(new Phrase("Marca"));
                table.AddCell(new Phrase("Modelo"));
                table.AddCell(new Phrase("Funcionalidad"));
                table.AddCell(new Phrase("Tipo"));
                table.AddCell(new Phrase("Nombre"));
                table.AddCell(new Phrase("Direccion"));
                table.AddCell(new Phrase("Telefono"));
                table.HeaderRows = 1;

                for (int i = 0; i < DgvConsulta.Columns.Count; i++)
                {
                    if (DgvConsulta[i, 0].Value != null)
                    {
                        if (i != 5)
                        {
                            table.AddCell(new Phrase(DgvConsulta.SelectedRows[0].Cells[i].Value.ToString()));
                        }
                    }
                }
                doc.Add(table);

                doc.Add(new Phrase(" "));

                PdfPTable tableDescripcion = new PdfPTable(1);
                tableDescripcion.AddCell(new Phrase("Descripcion"));
                tableDescripcion.HeaderRows = 1;
                tableDescripcion.AddCell(new Phrase(DgvConsulta.SelectedRows[0].Cells[5].Value.ToString()));
                doc.Add(tableDescripcion);

                doc.Close();
                Process.Start("Reporte1.pdf");
            }
            catch
            {
                MessageBox.Show("Error al generar archivo.");
            }

        }

        private void BtnAequipo_Click(object sender, EventArgs e)
        {
            ControlEquipo mControlEquipo = new ControlEquipo();
            try
            {
                Equipo mEquipo = new Equipo();

                mEquipo.No_Orden = DgvConsulta.SelectedRows[0].Cells[0].Value.ToString();
                mEquipo.Marca = DgvConsulta.SelectedRows[0].Cells[1].Value.ToString();
                mEquipo.Modelo = DgvConsulta.SelectedRows[0].Cells[2].Value.ToString();
                mEquipo.Funcionalidad = DgvConsulta.SelectedRows[0].Cells[3].Value.ToString();
                mEquipo.Tipo = DgvConsulta.SelectedRows[0].Cells[4].Value.ToString();
                mEquipo.Descripcion = DgvConsulta.SelectedRows[0].Cells[5].Value.ToString();

                mControlEquipo.ActualizarEquipo(mEquipo);

                MessageBox.Show("Actualizado Correctamente");

                DgvConsulta.DataSource = mControlEquipo.ConsultarEquipos();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnElininar_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = (int)DgvConsulta.SelectedRows[0].Cells[0].Value;

                ControlEquipo mControl = new ControlEquipo();
                mControl.EliminarEquipo(ID);
                MessageBox.Show("Eliminado exitosamente!");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error");
            }
        }
    }
}

namespace Proyecto_SDC.Interfaz
{
    partial class FRM_Consulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvConsulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoOrden = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnAequipo = new System.Windows.Forms.Button();
            this.BtnGR = new System.Windows.Forms.Button();
            this.BtnElininar = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvConsulta
            // 
            this.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsulta.Location = new System.Drawing.Point(24, 72);
            this.DgvConsulta.Name = "DgvConsulta";
            this.DgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvConsulta.Size = new System.Drawing.Size(577, 268);
            this.DgvConsulta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "No.Orden";
            // 
            // txtNoOrden
            // 
            this.txtNoOrden.Location = new System.Drawing.Point(80, 20);
            this.txtNoOrden.Name = "txtNoOrden";
            this.txtNoOrden.Size = new System.Drawing.Size(100, 20);
            this.txtNoOrden.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(233, 18);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnAequipo
            // 
            this.BtnAequipo.Location = new System.Drawing.Point(607, 97);
            this.BtnAequipo.Name = "BtnAequipo";
            this.BtnAequipo.Size = new System.Drawing.Size(97, 23);
            this.BtnAequipo.TabIndex = 4;
            this.BtnAequipo.Text = "Actualizar Equipo";
            this.BtnAequipo.UseVisualStyleBackColor = true;
            this.BtnAequipo.Click += new System.EventHandler(this.BtnAequipo_Click);
            // 
            // BtnGR
            // 
            this.BtnGR.Location = new System.Drawing.Point(607, 192);
            this.BtnGR.Name = "BtnGR";
            this.BtnGR.Size = new System.Drawing.Size(97, 23);
            this.BtnGR.TabIndex = 5;
            this.BtnGR.Text = "Genarar Reporte";
            this.BtnGR.UseVisualStyleBackColor = true;
            this.BtnGR.Click += new System.EventHandler(this.BtnGR_Click);
            // 
            // BtnElininar
            // 
            this.BtnElininar.Location = new System.Drawing.Point(105, 357);
            this.BtnElininar.Name = "BtnElininar";
            this.BtnElininar.Size = new System.Drawing.Size(75, 23);
            this.BtnElininar.TabIndex = 6;
            this.BtnElininar.Text = "Eliminar";
            this.BtnElininar.UseVisualStyleBackColor = true;
            this.BtnElininar.Click += new System.EventHandler(this.BtnElininar_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Location = new System.Drawing.Point(233, 357);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(75, 23);
            this.BtnMenu.TabIndex = 7;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // FRM_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 426);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnElininar);
            this.Controls.Add(this.BtnGR);
            this.Controls.Add(this.BtnAequipo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtNoOrden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvConsulta);
            this.Name = "FRM_Consulta";
            this.Text = "FRM_Consultar";
            this.Activated += new System.EventHandler(this.FRM_Consulta_Activated);
            this.Load += new System.EventHandler(this.FRM_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoOrden;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnAequipo;
        private System.Windows.Forms.Button BtnGR;
        private System.Windows.Forms.Button BtnElininar;
        private System.Windows.Forms.Button BtnMenu;
    }
}
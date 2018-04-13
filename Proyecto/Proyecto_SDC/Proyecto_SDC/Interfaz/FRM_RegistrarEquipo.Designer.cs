namespace Proyecto_SDC.Interfaz
{
    partial class FRM_RegistrarEquipo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cmbFuncionalidad = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.brnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No.Orden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Funcionalidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo";
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(107, 124);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(100, 20);
            this.txtOrden.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(107, 163);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(107, 202);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 7;
            // 
            // cmbFuncionalidad
            // 
            this.cmbFuncionalidad.FormattingEnabled = true;
            this.cmbFuncionalidad.Location = new System.Drawing.Point(307, 127);
            this.cmbFuncionalidad.Name = "cmbFuncionalidad";
            this.cmbFuncionalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbFuncionalidad.TabIndex = 8;
            this.cmbFuncionalidad.SelectedIndexChanged += new System.EventHandler(this.cmbFuncionalidad_SelectedIndexChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(307, 174);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(307, 277);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(107, 277);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cliente";
            // 
            // brnBuscar
            // 
            this.brnBuscar.Location = new System.Drawing.Point(231, 41);
            this.brnBuscar.Name = "brnBuscar";
            this.brnBuscar.Size = new System.Drawing.Size(75, 23);
            this.brnBuscar.TabIndex = 13;
            this.brnBuscar.Text = "Buscar";
            this.brnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(338, 43);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(107, 43);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 15;
            // 
            // FRM_RegistrarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 384);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.brnBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbFuncionalidad);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_RegistrarEquipo";
            this.Text = "FRM_RegistrarEquipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cmbFuncionalidad;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button brnBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtCliente;
    }
}
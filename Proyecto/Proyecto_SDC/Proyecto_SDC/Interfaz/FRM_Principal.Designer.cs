namespace Proyecto_SDC.Interfaz
{
    partial class FRM_Principal
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
            this.BtnRCliente = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnREquipo = new System.Windows.Forms.Button();
            this.BtnCerra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRCliente
            // 
            this.BtnRCliente.Location = new System.Drawing.Point(91, 28);
            this.BtnRCliente.Name = "BtnRCliente";
            this.BtnRCliente.Size = new System.Drawing.Size(93, 35);
            this.BtnRCliente.TabIndex = 0;
            this.BtnRCliente.Text = "Registrar Cliente";
            this.BtnRCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRCliente.UseVisualStyleBackColor = true;
            this.BtnRCliente.Click += new System.EventHandler(this.BtnRCliente_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(89, 69);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(95, 33);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar Estado";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnREquipo
            // 
            this.BtnREquipo.Location = new System.Drawing.Point(89, 108);
            this.BtnREquipo.Name = "BtnREquipo";
            this.BtnREquipo.Size = new System.Drawing.Size(95, 36);
            this.BtnREquipo.TabIndex = 2;
            this.BtnREquipo.Text = "Registrar Equipo";
            this.BtnREquipo.UseVisualStyleBackColor = true;
            this.BtnREquipo.Click += new System.EventHandler(this.BtnREquipo_Click);
            // 
            // BtnCerra
            // 
            this.BtnCerra.Location = new System.Drawing.Point(89, 150);
            this.BtnCerra.Name = "BtnCerra";
            this.BtnCerra.Size = new System.Drawing.Size(95, 33);
            this.BtnCerra.TabIndex = 3;
            this.BtnCerra.Text = "Cerrar ";
            this.BtnCerra.UseVisualStyleBackColor = true;
            this.BtnCerra.Click += new System.EventHandler(this.BtnCerra_Click);
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnCerra);
            this.Controls.Add(this.BtnREquipo);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnRCliente);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FRM_Principal";
            this.Text = "FRM_Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRCliente;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnREquipo;
        private System.Windows.Forms.Button BtnCerra;
    }
}
namespace pryCarrionTest
{
    partial class frmCargaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaProducto));
            this.txtCargaProducto = new System.Windows.Forms.TextBox();
            this.lblCargaProducto = new System.Windows.Forms.Label();
            this.btnCargaProducto = new System.Windows.Forms.Button();
            this.lblListaProductos = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ComboBox();
            this.panAdicional = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.radRepuesto = new System.Windows.Forms.RadioButton();
            this.radEquipo = new System.Windows.Forms.RadioButton();
            this.gbAdicional = new System.Windows.Forms.GroupBox();
            this.chkInstalacion = new System.Windows.Forms.CheckBox();
            this.chkEnvio = new System.Windows.Forms.CheckBox();
            this.chkGarantia = new System.Windows.Forms.CheckBox();
            this.btnAdicionales = new System.Windows.Forms.Button();
            this.panAdicional.SuspendLayout();
            this.gbTipo.SuspendLayout();
            this.gbAdicional.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCargaProducto
            // 
            this.txtCargaProducto.Location = new System.Drawing.Point(114, 12);
            this.txtCargaProducto.Name = "txtCargaProducto";
            this.txtCargaProducto.Size = new System.Drawing.Size(190, 20);
            this.txtCargaProducto.TabIndex = 0;
            this.txtCargaProducto.TextChanged += new System.EventHandler(this.txtCargaProducto_TextChanged);
            // 
            // lblCargaProducto
            // 
            this.lblCargaProducto.AutoSize = true;
            this.lblCargaProducto.Location = new System.Drawing.Point(12, 15);
            this.lblCargaProducto.Name = "lblCargaProducto";
            this.lblCargaProducto.Size = new System.Drawing.Size(44, 13);
            this.lblCargaProducto.TabIndex = 1;
            this.lblCargaProducto.Text = "Nombre";
            // 
            // btnCargaProducto
            // 
            this.btnCargaProducto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCargaProducto.Enabled = false;
            this.btnCargaProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargaProducto.Location = new System.Drawing.Point(310, 9);
            this.btnCargaProducto.Name = "btnCargaProducto";
            this.btnCargaProducto.Size = new System.Drawing.Size(100, 23);
            this.btnCargaProducto.TabIndex = 2;
            this.btnCargaProducto.Text = "Registrar";
            this.btnCargaProducto.UseVisualStyleBackColor = false;
            this.btnCargaProducto.Click += new System.EventHandler(this.btnCargaProducto_Click);
            // 
            // lblListaProductos
            // 
            this.lblListaProductos.AutoSize = true;
            this.lblListaProductos.Location = new System.Drawing.Point(12, 52);
            this.lblListaProductos.Name = "lblListaProductos";
            this.lblListaProductos.Size = new System.Drawing.Size(95, 13);
            this.lblListaProductos.TabIndex = 3;
            this.lblListaProductos.Text = "Lista de Productos";
            this.lblListaProductos.Click += new System.EventHandler(this.lblListaProductos_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(114, 47);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(190, 21);
            this.lstProductos.TabIndex = 4;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.lstProductos_SelectedIndexChanged);
            // 
            // panAdicional
            // 
            this.panAdicional.Controls.Add(this.btnAdicionales);
            this.panAdicional.Controls.Add(this.gbAdicional);
            this.panAdicional.Controls.Add(this.gbTipo);
            this.panAdicional.Location = new System.Drawing.Point(15, 83);
            this.panAdicional.Name = "panAdicional";
            this.panAdicional.Size = new System.Drawing.Size(395, 172);
            this.panAdicional.TabIndex = 5;
            this.panAdicional.Visible = false;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProductos.Enabled = false;
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProductos.Location = new System.Drawing.Point(310, 45);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(100, 23);
            this.btnProductos.TabIndex = 6;
            this.btnProductos.Text = "Siguiente";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.radEquipo);
            this.gbTipo.Controls.Add(this.radRepuesto);
            this.gbTipo.Location = new System.Drawing.Point(3, 3);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(389, 58);
            this.gbTipo.TabIndex = 0;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // radRepuesto
            // 
            this.radRepuesto.AutoSize = true;
            this.radRepuesto.Location = new System.Drawing.Point(7, 20);
            this.radRepuesto.Name = "radRepuesto";
            this.radRepuesto.Size = new System.Drawing.Size(46, 17);
            this.radRepuesto.TabIndex = 0;
            this.radRepuesto.TabStop = true;
            this.radRepuesto.Text = "Tipo";
            this.radRepuesto.UseVisualStyleBackColor = true;
            // 
            // radEquipo
            // 
            this.radEquipo.AutoSize = true;
            this.radEquipo.Location = new System.Drawing.Point(192, 20);
            this.radEquipo.Name = "radEquipo";
            this.radEquipo.Size = new System.Drawing.Size(58, 17);
            this.radEquipo.TabIndex = 1;
            this.radEquipo.TabStop = true;
            this.radEquipo.Text = "Equipo";
            this.radEquipo.UseVisualStyleBackColor = true;
            // 
            // gbAdicional
            // 
            this.gbAdicional.Controls.Add(this.chkGarantia);
            this.gbAdicional.Controls.Add(this.chkEnvio);
            this.gbAdicional.Controls.Add(this.chkInstalacion);
            this.gbAdicional.Location = new System.Drawing.Point(3, 67);
            this.gbAdicional.Name = "gbAdicional";
            this.gbAdicional.Size = new System.Drawing.Size(389, 70);
            this.gbAdicional.TabIndex = 1;
            this.gbAdicional.TabStop = false;
            this.gbAdicional.Text = "Adicional";
            // 
            // chkInstalacion
            // 
            this.chkInstalacion.AutoSize = true;
            this.chkInstalacion.Location = new System.Drawing.Point(7, 20);
            this.chkInstalacion.Name = "chkInstalacion";
            this.chkInstalacion.Size = new System.Drawing.Size(77, 17);
            this.chkInstalacion.TabIndex = 0;
            this.chkInstalacion.Text = "Instalación";
            this.chkInstalacion.UseVisualStyleBackColor = true;
            // 
            // chkEnvio
            // 
            this.chkEnvio.AutoSize = true;
            this.chkEnvio.Location = new System.Drawing.Point(192, 20);
            this.chkEnvio.Name = "chkEnvio";
            this.chkEnvio.Size = new System.Drawing.Size(55, 17);
            this.chkEnvio.TabIndex = 1;
            this.chkEnvio.Text = "Envío";
            this.chkEnvio.UseVisualStyleBackColor = true;
            // 
            // chkGarantia
            // 
            this.chkGarantia.AutoSize = true;
            this.chkGarantia.Location = new System.Drawing.Point(7, 44);
            this.chkGarantia.Name = "chkGarantia";
            this.chkGarantia.Size = new System.Drawing.Size(132, 17);
            this.chkGarantia.TabIndex = 2;
            this.chkGarantia.Text = "Extensión de Garantía";
            this.chkGarantia.UseVisualStyleBackColor = true;
            // 
            // btnAdicionales
            // 
            this.btnAdicionales.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdicionales.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdicionales.Location = new System.Drawing.Point(295, 143);
            this.btnAdicionales.Name = "btnAdicionales";
            this.btnAdicionales.Size = new System.Drawing.Size(97, 23);
            this.btnAdicionales.TabIndex = 2;
            this.btnAdicionales.Text = "Siguiente";
            this.btnAdicionales.UseVisualStyleBackColor = false;
            // 
            // frmCargaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 268);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.panAdicional);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.lblListaProductos);
            this.Controls.Add(this.btnCargaProducto);
            this.Controls.Add(this.lblCargaProducto);
            this.Controls.Add(this.txtCargaProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Producto";
            this.panAdicional.ResumeLayout(false);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.gbAdicional.ResumeLayout(false);
            this.gbAdicional.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCargaProducto;
        private System.Windows.Forms.Label lblCargaProducto;
        private System.Windows.Forms.Button btnCargaProducto;
        private System.Windows.Forms.Label lblListaProductos;
        private System.Windows.Forms.ComboBox lstProductos;
        private System.Windows.Forms.Panel panAdicional;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton radRepuesto;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnAdicionales;
        private System.Windows.Forms.GroupBox gbAdicional;
        private System.Windows.Forms.CheckBox chkGarantia;
        private System.Windows.Forms.CheckBox chkEnvio;
        private System.Windows.Forms.CheckBox chkInstalacion;
        private System.Windows.Forms.RadioButton radEquipo;
    }
}
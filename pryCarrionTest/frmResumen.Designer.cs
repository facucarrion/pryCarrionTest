namespace pryCarrionTest
{
    partial class frmResumen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumen));
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblAdicional = new System.Windows.Forms.Label();
            this.lblProductoCargado = new System.Windows.Forms.Label();
            this.lblTipoCargado = new System.Windows.Forms.Label();
            this.lblAdicionalCargado = new System.Windows.Forms.Label();
            this.btnFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(12, 9);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 33);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblAdicional
            // 
            this.lblAdicional.AutoSize = true;
            this.lblAdicional.Location = new System.Drawing.Point(12, 59);
            this.lblAdicional.Name = "lblAdicional";
            this.lblAdicional.Size = new System.Drawing.Size(53, 13);
            this.lblAdicional.TabIndex = 2;
            this.lblAdicional.Text = "Adicional:";
            this.lblAdicional.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProductoCargado
            // 
            this.lblProductoCargado.AutoSize = true;
            this.lblProductoCargado.Location = new System.Drawing.Point(71, 9);
            this.lblProductoCargado.Name = "lblProductoCargado";
            this.lblProductoCargado.Size = new System.Drawing.Size(0, 13);
            this.lblProductoCargado.TabIndex = 3;
            // 
            // lblTipoCargado
            // 
            this.lblTipoCargado.AutoSize = true;
            this.lblTipoCargado.Location = new System.Drawing.Point(71, 33);
            this.lblTipoCargado.Name = "lblTipoCargado";
            this.lblTipoCargado.Size = new System.Drawing.Size(0, 13);
            this.lblTipoCargado.TabIndex = 4;
            // 
            // lblAdicionalCargado
            // 
            this.lblAdicionalCargado.AutoSize = true;
            this.lblAdicionalCargado.Location = new System.Drawing.Point(74, 59);
            this.lblAdicionalCargado.Name = "lblAdicionalCargado";
            this.lblAdicionalCargado.Size = new System.Drawing.Size(0, 13);
            this.lblAdicionalCargado.TabIndex = 5;
            // 
            // btnFin
            // 
            this.btnFin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFin.Location = new System.Drawing.Point(15, 84);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(298, 23);
            this.btnFin.TabIndex = 6;
            this.btnFin.Text = "Fin";
            this.btnFin.UseVisualStyleBackColor = false;
            // 
            // frmResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 119);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.lblAdicionalCargado);
            this.Controls.Add(this.lblTipoCargado);
            this.Controls.Add(this.lblProductoCargado);
            this.Controls.Add(this.lblAdicional);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen";
            this.Load += new System.EventHandler(this.frmResumen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblAdicional;
        private System.Windows.Forms.Label lblProductoCargado;
        private System.Windows.Forms.Label lblTipoCargado;
        private System.Windows.Forms.Label lblAdicionalCargado;
        private System.Windows.Forms.Button btnFin;
    }
}
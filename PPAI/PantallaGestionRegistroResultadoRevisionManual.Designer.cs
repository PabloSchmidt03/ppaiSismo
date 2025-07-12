namespace PPAI
{
    partial class PantallaGestionRegistroResultadoRevisionManual
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.boton_opcion = new System.Windows.Forms.Button();
            this.dgvDatosEventos = new System.Windows.Forms.DataGridView();
            this.lblSeleccionarEvento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // boton_opcion
            // 
            this.boton_opcion.Location = new System.Drawing.Point(136, 166);
            this.boton_opcion.Name = "boton_opcion";
            this.boton_opcion.Size = new System.Drawing.Size(522, 76);
            this.boton_opcion.TabIndex = 0;
            this.boton_opcion.Text = "Registrar resultado de revision manual";
            this.boton_opcion.UseVisualStyleBackColor = true;
            this.boton_opcion.Click += new System.EventHandler(this.seleccionarOpciónRegistrarResultadoDeRevisiónManual);
            // 
            // dgvDatosEventos
            // 
            this.dgvDatosEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosEventos.Location = new System.Drawing.Point(12, 228);
            this.dgvDatosEventos.MultiSelect = false;
            this.dgvDatosEventos.Name = "dgvDatosEventos";
            this.dgvDatosEventos.ReadOnly = true;
            this.dgvDatosEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosEventos.Size = new System.Drawing.Size(776, 150);
            this.dgvDatosEventos.TabIndex = 2;
            this.dgvDatosEventos.Visible = false;
            this.dgvDatosEventos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tomarSeleccionEventoSismico);
            // 
            // lblSeleccionarEvento
            // 
            this.lblSeleccionarEvento.AutoSize = true;
            this.lblSeleccionarEvento.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarEvento.Location = new System.Drawing.Point(242, 124);
            this.lblSeleccionarEvento.Name = "lblSeleccionarEvento";
            this.lblSeleccionarEvento.Size = new System.Drawing.Size(0, 27);
            this.lblSeleccionarEvento.TabIndex = 3;
            // 
            // PantallaGestionRegistroResultadoRevisionManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSeleccionarEvento);
            this.Controls.Add(this.dgvDatosEventos);
            this.Controls.Add(this.boton_opcion);
            this.Name = "PantallaGestionRegistroResultadoRevisionManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar resultado de revision manual";
            this.Load += new System.EventHandler(this.PantallaGestionRegistroResultadoRevisionManual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_opcion;
        private System.Windows.Forms.DataGridView dgvDatosEventos;
        private System.Windows.Forms.Label lblSeleccionarEvento;
    }
}


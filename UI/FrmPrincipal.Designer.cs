namespace UI
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PnFondo = new System.Windows.Forms.Panel();
            this.PnFormulario = new System.Windows.Forms.Panel();
            this.PnOpciones = new System.Windows.Forms.Panel();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BntEliminar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnAñadir = new System.Windows.Forms.Button();
            this.PnFondo.SuspendLayout();
            this.PnOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnFondo
            // 
            this.PnFondo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PnFondo.Controls.Add(this.PnFormulario);
            this.PnFondo.Controls.Add(this.PnOpciones);
            this.PnFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnFondo.Location = new System.Drawing.Point(0, 0);
            this.PnFondo.Name = "PnFondo";
            this.PnFondo.Size = new System.Drawing.Size(834, 461);
            this.PnFondo.TabIndex = 0;
            // 
            // PnFormulario
            // 
            this.PnFormulario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnFormulario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnFormulario.BackgroundImage")));
            this.PnFormulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PnFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnFormulario.Location = new System.Drawing.Point(200, 0);
            this.PnFormulario.Name = "PnFormulario";
            this.PnFormulario.Size = new System.Drawing.Size(634, 461);
            this.PnFormulario.TabIndex = 1;
            // 
            // PnOpciones
            // 
            this.PnOpciones.BackColor = System.Drawing.SystemColors.Highlight;
            this.PnOpciones.Controls.Add(this.BtnModificar);
            this.PnOpciones.Controls.Add(this.BntEliminar);
            this.PnOpciones.Controls.Add(this.BtnConsultar);
            this.PnOpciones.Controls.Add(this.BtnAñadir);
            this.PnOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnOpciones.Location = new System.Drawing.Point(0, 0);
            this.PnOpciones.Name = "PnOpciones";
            this.PnOpciones.Size = new System.Drawing.Size(200, 461);
            this.PnOpciones.TabIndex = 0;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificar.Location = new System.Drawing.Point(21, 310);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(160, 40);
            this.BtnModificar.TabIndex = 1;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BntEliminar
            // 
            this.BntEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BntEliminar.Image")));
            this.BntEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BntEliminar.Location = new System.Drawing.Point(21, 247);
            this.BntEliminar.Name = "BntEliminar";
            this.BntEliminar.Size = new System.Drawing.Size(160, 40);
            this.BntEliminar.TabIndex = 1;
            this.BntEliminar.Text = "Eliminar";
            this.BntEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BntEliminar.UseVisualStyleBackColor = true;
            this.BntEliminar.Click += new System.EventHandler(this.BntEliminar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultar.Image")));
            this.BtnConsultar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnConsultar.Location = new System.Drawing.Point(21, 184);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(160, 40);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // BtnAñadir
            // 
            this.BtnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("BtnAñadir.Image")));
            this.BtnAñadir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAñadir.Location = new System.Drawing.Point(21, 121);
            this.BtnAñadir.Name = "BtnAñadir";
            this.BtnAñadir.Size = new System.Drawing.Size(160, 40);
            this.BtnAñadir.TabIndex = 1;
            this.BtnAñadir.Text = "Añadir";
            this.BtnAñadir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAñadir.UseVisualStyleBackColor = true;
            this.BtnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.PnFondo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pulsaciones";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PnFondo.ResumeLayout(false);
            this.PnOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnFondo;
        private System.Windows.Forms.Panel PnOpciones;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BntEliminar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnAñadir;
        private System.Windows.Forms.Panel PnFormulario;
    }
}


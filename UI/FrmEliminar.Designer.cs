namespace UI
{
    partial class FrmEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminar));
            this.BtnClose = new System.Windows.Forms.Button();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.LbSexo = new System.Windows.Forms.Label();
            this.LbEdad = new System.Windows.Forms.Label();
            this.LbNombre = new System.Windows.Forms.Label();
            this.LbIdentificacion = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(531, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(41, 23);
            this.BtnClose.TabIndex = 11;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // CmbSexo
            // 
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CmbSexo.Location = new System.Drawing.Point(196, 185);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(130, 21);
            this.CmbSexo.TabIndex = 19;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(196, 143);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(130, 20);
            this.TxtEdad.TabIndex = 18;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(196, 104);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(130, 20);
            this.TxtNombre.TabIndex = 17;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(196, 58);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(130, 20);
            this.TxtIdentificacion.TabIndex = 16;
            // 
            // LbSexo
            // 
            this.LbSexo.AutoSize = true;
            this.LbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSexo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbSexo.Location = new System.Drawing.Point(136, 185);
            this.LbSexo.Name = "LbSexo";
            this.LbSexo.Size = new System.Drawing.Size(54, 20);
            this.LbSexo.TabIndex = 15;
            this.LbSexo.Text = "Sexo:";
            // 
            // LbEdad
            // 
            this.LbEdad.AutoSize = true;
            this.LbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEdad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbEdad.Location = new System.Drawing.Point(134, 143);
            this.LbEdad.Name = "LbEdad";
            this.LbEdad.Size = new System.Drawing.Size(56, 20);
            this.LbEdad.TabIndex = 14;
            this.LbEdad.Text = "Edad:";
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbNombre.Location = new System.Drawing.Point(114, 104);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(76, 20);
            this.LbNombre.TabIndex = 13;
            this.LbNombre.Text = "Nombre:";
            // 
            // LbIdentificacion
            // 
            this.LbIdentificacion.AutoSize = true;
            this.LbIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIdentificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbIdentificacion.Location = new System.Drawing.Point(68, 58);
            this.LbIdentificacion.Name = "LbIdentificacion";
            this.LbIdentificacion.Size = new System.Drawing.Size(122, 20);
            this.LbIdentificacion.TabIndex = 12;
            this.LbIdentificacion.Text = "Identificacion:";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminar.Location = new System.Drawing.Point(206, 241);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(110, 40);
            this.BtnEliminar.TabIndex = 20;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscar.Location = new System.Drawing.Point(356, 56);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(110, 40);
            this.BtnBuscar.TabIndex = 21;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.LbSexo);
            this.Controls.Add(this.LbEdad);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.LbIdentificacion);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEliminar";
            this.Text = "FrmEliminar";
            this.Load += new System.EventHandler(this.FrmEliminar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label LbSexo;
        private System.Windows.Forms.Label LbEdad;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.Label LbIdentificacion;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnBuscar;
    }
}
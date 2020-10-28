namespace UI
{
    partial class FrmModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificar));
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.LbSexo = new System.Windows.Forms.Label();
            this.LbEdad = new System.Windows.Forms.Label();
            this.LbNombre = new System.Windows.Forms.Label();
            this.LbIdentificacion = new System.Windows.Forms.Label();
            this.BtnEditar = new System.Windows.Forms.Button();
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
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscar.Location = new System.Drawing.Point(373, 44);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(110, 40);
            this.BtnBuscar.TabIndex = 22;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // CmbSexo
            // 
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CmbSexo.Location = new System.Drawing.Point(202, 172);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(130, 21);
            this.CmbSexo.TabIndex = 30;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(202, 130);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(130, 20);
            this.TxtEdad.TabIndex = 29;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(202, 91);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(130, 20);
            this.TxtNombre.TabIndex = 28;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(202, 45);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(130, 20);
            this.TxtIdentificacion.TabIndex = 27;
            // 
            // LbSexo
            // 
            this.LbSexo.AutoSize = true;
            this.LbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSexo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbSexo.Location = new System.Drawing.Point(142, 172);
            this.LbSexo.Name = "LbSexo";
            this.LbSexo.Size = new System.Drawing.Size(54, 20);
            this.LbSexo.TabIndex = 26;
            this.LbSexo.Text = "Sexo:";
            // 
            // LbEdad
            // 
            this.LbEdad.AutoSize = true;
            this.LbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEdad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbEdad.Location = new System.Drawing.Point(140, 130);
            this.LbEdad.Name = "LbEdad";
            this.LbEdad.Size = new System.Drawing.Size(56, 20);
            this.LbEdad.TabIndex = 25;
            this.LbEdad.Text = "Edad:";
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbNombre.Location = new System.Drawing.Point(120, 91);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(76, 20);
            this.LbNombre.TabIndex = 24;
            this.LbNombre.Text = "Nombre:";
            // 
            // LbIdentificacion
            // 
            this.LbIdentificacion.AutoSize = true;
            this.LbIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIdentificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbIdentificacion.Location = new System.Drawing.Point(74, 45);
            this.LbIdentificacion.Name = "LbIdentificacion";
            this.LbIdentificacion.Size = new System.Drawing.Size(122, 20);
            this.LbIdentificacion.TabIndex = 23;
            this.LbIdentificacion.Text = "Identificacion:";
            // 
            // BtnEditar
            // 
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditar.Location = new System.Drawing.Point(211, 230);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(110, 40);
            this.BtnEditar.TabIndex = 31;
            this.BtnEditar.Text = "Modificar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // FrmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.LbSexo);
            this.Controls.Add(this.LbEdad);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.LbIdentificacion);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificar";
            this.Text = "FrmModificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label LbSexo;
        private System.Windows.Forms.Label LbEdad;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.Label LbIdentificacion;
        private System.Windows.Forms.Button BtnEditar;
    }
}
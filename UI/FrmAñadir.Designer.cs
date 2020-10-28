namespace UI
{
    partial class FrmAñadir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAñadir));
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LbIdentificacion = new System.Windows.Forms.Label();
            this.LbNombre = new System.Windows.Forms.Label();
            this.LbEdad = new System.Windows.Forms.Label();
            this.LbSexo = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.CmbSExo = new System.Windows.Forms.ComboBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.Location = new System.Drawing.Point(235, 246);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(103, 51);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LbIdentificacion
            // 
            this.LbIdentificacion.AutoSize = true;
            this.LbIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIdentificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbIdentificacion.Location = new System.Drawing.Point(92, 71);
            this.LbIdentificacion.Name = "LbIdentificacion";
            this.LbIdentificacion.Size = new System.Drawing.Size(122, 20);
            this.LbIdentificacion.TabIndex = 1;
            this.LbIdentificacion.Text = "Identificacion:";
            this.LbIdentificacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbNombre.Location = new System.Drawing.Point(138, 117);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(76, 20);
            this.LbNombre.TabIndex = 3;
            this.LbNombre.Text = "Nombre:";
            // 
            // LbEdad
            // 
            this.LbEdad.AutoSize = true;
            this.LbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEdad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbEdad.Location = new System.Drawing.Point(158, 156);
            this.LbEdad.Name = "LbEdad";
            this.LbEdad.Size = new System.Drawing.Size(56, 20);
            this.LbEdad.TabIndex = 4;
            this.LbEdad.Text = "Edad:";
            // 
            // LbSexo
            // 
            this.LbSexo.AutoSize = true;
            this.LbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSexo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbSexo.Location = new System.Drawing.Point(160, 198);
            this.LbSexo.Name = "LbSexo";
            this.LbSexo.Size = new System.Drawing.Size(54, 20);
            this.LbSexo.TabIndex = 5;
            this.LbSexo.Text = "Sexo:";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(220, 71);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(130, 20);
            this.TxtIdentificacion.TabIndex = 6;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(220, 117);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(130, 20);
            this.TxtNombre.TabIndex = 7;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(220, 156);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(130, 20);
            this.TxtEdad.TabIndex = 8;
            // 
            // CmbSExo
            // 
            this.CmbSExo.FormattingEnabled = true;
            this.CmbSExo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CmbSExo.Location = new System.Drawing.Point(220, 198);
            this.CmbSExo.Name = "CmbSExo";
            this.CmbSExo.Size = new System.Drawing.Size(130, 21);
            this.CmbSExo.TabIndex = 9;
            this.CmbSExo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnClose
            // 
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(547, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(41, 23);
            this.BtnClose.TabIndex = 10;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmAñadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.CmbSExo);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.LbSexo);
            this.Controls.Add(this.LbEdad);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.LbIdentificacion);
            this.Controls.Add(this.BtnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAñadir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LbIdentificacion;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.Label LbEdad;
        private System.Windows.Forms.Label LbSexo;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.ComboBox CmbSExo;
        private System.Windows.Forms.Button BtnClose;
    }
}
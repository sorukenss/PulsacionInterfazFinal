namespace PulsacionInterfaz
{
    partial class FrmPrincipall
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
            this.PnFondo = new System.Windows.Forms.Panel();
            this.PnMenu = new System.Windows.Forms.Panel();
            this.BtnAñadir = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.PnFondo.SuspendLayout();
            this.PnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnFondo
            // 
            this.PnFondo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PnFondo.Controls.Add(this.PnMenu);
            this.PnFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnFondo.Location = new System.Drawing.Point(0, 0);
            this.PnFondo.Name = "PnFondo";
            this.PnFondo.Size = new System.Drawing.Size(800, 450);
            this.PnFondo.TabIndex = 0;
            // 
            // PnMenu
            // 
            this.PnMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.PnMenu.Controls.Add(this.BtnModificar);
            this.PnMenu.Controls.Add(this.BtnEliminar);
            this.PnMenu.Controls.Add(this.BtnConsultar);
            this.PnMenu.Controls.Add(this.BtnAñadir);
            this.PnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnMenu.Location = new System.Drawing.Point(0, 0);
            this.PnMenu.Name = "PnMenu";
            this.PnMenu.Size = new System.Drawing.Size(229, 450);
            this.PnMenu.TabIndex = 0;
            // 
            // BtnAñadir
            // 
            this.BtnAñadir.Location = new System.Drawing.Point(31, 162);
            this.BtnAñadir.Name = "BtnAñadir";
            this.BtnAñadir.Size = new System.Drawing.Size(160, 40);
            this.BtnAñadir.TabIndex = 1;
            this.BtnAñadir.Text = "Añadir";
            this.BtnAñadir.UseVisualStyleBackColor = true;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(31, 233);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(160, 40);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(31, 304);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(160, 40);
            this.BtnEliminar.TabIndex = 1;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(31, 375);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(160, 40);
            this.BtnModificar.TabIndex = 1;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnFondo);
            this.Name = "FrmPrincipal";
            this.PnFondo.ResumeLayout(false);
            this.PnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnFondo;
        private System.Windows.Forms.Panel PnMenu;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnAñadir;
    }
}
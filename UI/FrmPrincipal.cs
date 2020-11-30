using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace UI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }
       
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario<MiForm>() where MiForm: Form, new()
        {
            Form formulario;
            formulario = PnFormulario.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                PnFormulario.Controls.Add(formulario);
                PnFormulario.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {

            AbrirFormulario<FrmAñadir>();
            
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmConsultar>();
        }

        private void BntEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmEliminar>();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmModificar>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmConection>();
        }
    }
}

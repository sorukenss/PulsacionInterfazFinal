using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace UI
{
    public partial class FrmConsultar : Form
    {
        PersonaService personaService = new PersonaService();
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DtgPaciente.DataSource = null;
            DtgPaciente.DataSource = personaService.ConsultarPersonas();
        }
    }
}

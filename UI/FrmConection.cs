using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class FrmConection : Form
    {
        public PersonaService perser;
       
        public FrmConection()
        {
            InitializeComponent();
            perser = new PersonaService(ConfigConection.Connection);
        }

        private void FrmConection_Load(object sender, EventArgs e)
        {
            var respuesta = perser.ProbarConection();
            if (respuesta.EstadoError == true)
            {
                MessageBox.Show("Error :" + respuesta.Error);
            }
            else
            {
                MessageBox.Show("Estado :" + respuesta.Abierto +"\nEstado :"+respuesta.Cerrado);
              
            }
           

            

        }
    }
}

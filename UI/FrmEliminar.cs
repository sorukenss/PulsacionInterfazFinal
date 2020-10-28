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
    public partial class FrmEliminar : Form
    {
        PersonaService personaService = new PersonaService();
        Persona persona;

        public FrmEliminar()
        {
            InitializeComponent();
            InHabilitar();
            
        }
        private void InHabilitar()
        {
            TxtNombre.Enabled = false;
            TxtEdad.Enabled = false;
            CmbSexo.Enabled = false;
            
        }

        private void Limpiar()
        {
            TxtIdentificacion.Text = "";
            TxtNombre.Text = "";
            TxtEdad.Text = "";
            CmbSexo.Text = "";
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEliminar_Load(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            persona = new Persona();

            persona = personaService.BuscarPersona(TxtIdentificacion.Text);
            if (persona != null)
            {
                personaService.Eliminar(persona);
                MessageBox.Show("Persona eliminada correctamente");
               
            }
            else
            {
                MessageBox.Show("No se encontró la identificación que busca");
                
            }
            Limpiar();


        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            persona = new Persona();
            persona = personaService.BuscarPersona(TxtIdentificacion.Text);
            if (persona != null)
            {
                TxtNombre.Text = persona.Nombre;
                TxtEdad.Text = persona.Edad.ToString();
                CmbSexo.Text = persona.Sexo;
                MessageBox.Show("Se Encontro");
            }
            else
            {
                MessageBox.Show("No se Encontro");
            }
            TxtIdentificacion.Enabled = false;
        }
    }
}

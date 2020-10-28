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
    public partial class FrmAñadir : Form
    {
        public FrmAñadir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonaService personaService = new PersonaService();
            Persona persona = new Persona();
            persona.Identificacion = TxtIdentificacion.Text;
            persona.Nombre = TxtNombre.Text;
            persona.Edad = int.Parse(TxtEdad.Text);
            persona.Sexo = CmbSExo.Text;
            persona.CalcularPulsacion();
            MessageBox.Show(personaService.Guardar(persona)+"Pulsacion:"+persona.Pulsacion);
            
            Limpiar();

        }

        public void Limpiar()
        {
            TxtIdentificacion.Text = "";
            TxtNombre.Text = "";
            TxtEdad.Text = "";
            CmbSExo.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

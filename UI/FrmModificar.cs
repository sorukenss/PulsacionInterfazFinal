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
    public partial class FrmModificar : Form
    {
        Persona persona;
        PersonaService personaService = new PersonaService();
        public FrmModificar()
        {
            InitializeComponent();
            InHabilitarText();
        }



        private void InHabilitarText()
        {
            TxtNombre.Enabled = false;
            TxtEdad.Enabled = false;
            CmbSexo.Enabled = false;
        }

        private void HabilitarText()
        {
            TxtNombre.Enabled = true;
            TxtEdad.Enabled = true;
            CmbSexo.Enabled = true;
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
            HabilitarText();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Persona personaNueva = new Persona();
            personaNueva.Identificacion = TxtIdentificacion.Text;
            personaNueva.Nombre = TxtNombre.Text;
            personaNueva.Edad = int.Parse(TxtEdad.Text);
            personaNueva.Sexo = CmbSexo.Text;
            personaNueva.CalcularPulsacion();
            var mensaje = personaService.Modificar(persona, personaNueva);
            MessageBox.Show(mensaje);
            Limpiar();

        }
    }
}

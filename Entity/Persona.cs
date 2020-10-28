using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {

        public string Nombre { get; set; }

        public string Identificacion { get; set; }

        public string Sexo { get; set; }

        public int Edad { get; set; }

        public decimal Pulsacion { get; set; }

        public Persona(string identificacion, string nombre, int edad, string sexo)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;

        }

        public Persona()
        {

        }

        public void CalcularPulsacion()
        {
            if (Sexo.ToUpper().Equals("MASCULINO"))
            {
                Pulsacion = (210 - Edad) / 10;
            }
            else if (Sexo.ToUpper().Equals("FEMENINO"))
            {
                Pulsacion = (220 - Edad) / 10;
            }
            else
            {
                Pulsacion = 0;
            }
        }
    }
}

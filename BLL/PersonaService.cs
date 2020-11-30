using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class PersonaService
    {
        public ConnectionManager Connection;
        private PersonaRepository personaRepository;
        public List<Persona> personas;
        Persona persona;
        public PersonaService(string connection)
        {
            Connection = new ConnectionManager(connection);
            personaRepository = new PersonaRepository(Connection);

        }


        public RespuestaEstado ProbarConection()
        {
            RespuestaEstado res;
            string abierto, cerrado,version;
            try
            {

                Connection.Open();
                abierto = Connection.Estado();
                version = Connection.Version();
                Connection.Close();
                cerrado = Connection.Estado();
                res = new RespuestaEstado(abierto, cerrado,version);

            }
            catch(Exception e)
            {
                res = new RespuestaEstado(e.Message);
                
            }
            return res;
        }



        public PersonaService()
        {
            ConsultarPersonas();
        }

        public string Guardar(Persona persona)
        {
            try
            {
                if (personaRepository.BuscarPersona(persona.Identificacion) == null)
                {
                    personas.Add(persona);
                    personaRepository.Guardar(personas);
                    return "La persona se guardo con exito";
                }
                else
                {
                    return " Esta Persona ya se encuentra Registrada";
                }

            }
            catch (Exception e)
            {
                return $"Error {e.Message}";
            }

        }

        public string Modificar(Persona persona, Persona personanueva)
        {
            try
            {
                personaRepository.Modificar(persona, personanueva);
                return "Se modifico con exito ";
            }
            catch (Exception e)
            {
                return $"No se pudo modificar Error {e.Message}";
            }

        }

        public void Eliminar(Persona persona)
        {
            personaRepository.Eliminar(persona);
        }

        public Persona BuscarPersona(string identificacion)
        {
            persona = new Persona();
            persona = personaRepository.BuscarPersona(identificacion);
            if (persona == null)
            {
                return null;
            }
            return persona;
        }

        public List<Persona> ConsultarPersonas()
        {
            personaRepository = new PersonaRepository();
            personas = personaRepository.ConsultarPersonas();
            return personas;
        }



    }

    public class RespuestaEstado
    {
        public string Abierto { get; set; }
        public string Cerrado { get; set; }

        public string  Version { get; set; }

        public string Error { get; set; }
        public  bool EstadoError { get; set; }


        public RespuestaEstado(string open,string close,string version)
        {
            Abierto = open;
            Cerrado = close;
            Version = version;
            EstadoError = false;
        }

        public RespuestaEstado(string mensaje)
        {
            Error = mensaje;
            EstadoError = true;
        }

    }



}

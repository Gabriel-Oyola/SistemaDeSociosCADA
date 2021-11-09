using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeSociosCADA.Clases
{
    public class Persona
    {
        public string NumSocio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Nacimiento { get; set; }

        public int Edad { get; set; }
        public string Documento { get; set; }
        public string Carnet { get; set; }
        public string Platea { get; set; }

        public string Estado { get; set; }

        public bool validar()
        {
            bool resp = false;

            if (Edad > 0 && Edad < 100)
            {
                resp = true;
            }

            return resp;
        }
    }
}
